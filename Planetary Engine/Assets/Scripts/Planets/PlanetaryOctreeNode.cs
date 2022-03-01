using Unity.Entities;
using Unity.Mathematics;

public struct PlanetaryOctreeNode : IComponentData
{

    public float3 position;
    public Entity entity;

    public float size;
    public int depth;

}
