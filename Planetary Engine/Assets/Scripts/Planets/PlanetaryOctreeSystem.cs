using System.Collections;
using Unity.Collections;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

public class PlanetaryOctreeSystem : SystemBase
{

    //BottomLeftFront = 0
    //BottomLeftBack = 1
    //BottomRightFront = 2
    //BottomRightBack = 3
    //TopLeftFront = 4
    //TopLeftBack = 5
    //TopRightFront = 6
    //TopRightBack = 7
    EndSimulationEntityCommandBufferSystem m_EndSimulationEcbSystem;

    protected override void OnCreate()
    {
        m_EndSimulationEcbSystem = World.GetOrCreateSystem<EndSimulationEntityCommandBufferSystem>();
    }

    protected override void OnUpdate()
    {
        
    }

    public void Subdivide(Entity entity)
    {
        PlanetaryOctreeNode node = EntityManager.GetComponentData<PlanetaryOctreeNode>(entity);
        var subNodes = EntityManager.GetBuffer<PlanetaryOctreeSubNodes>(entity);

        NativeArray<PlanetaryOctreeNode> newSubNodes = new NativeArray<PlanetaryOctreeNode>(8, Allocator.Temp);
        float3 position = node.position;
        float size = node.size;
        int depth = node.depth;
        for (int i = 0; i < newSubNodes.Length; ++i)
        {
            float3 newPos = position;
            if ((i & 4) == 4)
            {
                newPos.y += size * 0.25f;
            }
            else
            {
                newPos.y -= size * 0.25f;
            }

            if ((i & 2) == 2)
            {
                newPos.x += size * 0.25f;
            }
            else
            {
                newPos.x -= size * 0.25f;
            }

            if ((i & 1) == 1)
            {
                newPos.z += size * 0.25f;
            }
            else
            {
                newPos.z -= size * 0.25f;
            }

            newSubNodes[i] = new PlanetaryOctreeNode { position = newPos, size = size * 0.5f, depth = depth };
        }
    }
}
