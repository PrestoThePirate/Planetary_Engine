using System.Collections;
using UnityEngine;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

public class TestSystem : SystemBase
{
    private EndInitializationEntityCommandBufferSystem _endInitializationEntityCommandBufferSystem;

    protected override void OnCreate()
    {
        //Entity newEntity = EntityManager.CreateEntity();

        //EntityManager.AddComponentData(newEntity, new Test
        //{
        //    Value = new float3(0,0,0),
        //    TestList = new NativeList<float3>()
        //});
    }

    private void OnCreated()
    {
        //_endInitializationEntityCommandBufferSystem = World.GetOrCreateSystem<EndInitializationEntityCommandBufferSystem>();
        //var ecb = _endInitializationEntityCommandBufferSystem.CreateCommandBuffer();

        //MakeEntityWithDynamicBuffer();

        //Entities.ForEach((Entity entity, Test com) =>
        //{
            
        //    EntityManager entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
        //    DynamicBuffer<PlanetaryOctreeSubNodes> dyn = entityManager.GetBuffer<PlanetaryOctreeSubNodes>(entity);
        //    Entity testEntity = ecb.CreateEntity();
            
        //    //dyn.Add(new PlanetaryOctreeSubNodes { Value = testEntity });

        //    DynamicBuffer<Entity> EDB = entityManager.GetBuffer<PlanetaryOctreeSubNodes>(entity).Reinterpret<Entity>();
        //    //EDB.Add(testEntity);
        //    Debug.Log(EDB.Length);

        //    Entity[,,] VectorArray = new Entity[3, 3, 3];

        //    for (int x = 0; x < VectorArray.GetLength(0); x++)
        //    {
        //        for (int y = 0; y < VectorArray.GetLength(1); y++)
        //        {
        //            for (int z = 0; z < VectorArray.GetLength(2); z++)
        //            {
        //                VectorArray[x, y, z] = ecb.CreateEntity();
        //            }
        //        }
        //    }

        //    Entity[] FlattenedArray = Utility.Flatten<Entity>.Flatten3DArray(VectorArray);

        //    for (int i = 0; i < FlattenedArray.Length; i++)
        //    {
        //        EDB.Add(FlattenedArray[i]);
        //    }
        //    Debug.Log(EDB.Length);

        //    Debug.Log(Utility.Flatten<Entity>.ReadFlattenedArray(EDB.AsNativeArray().ToArray(), new int3(3,3,3), new int3(0,0,0)).Index);


        //}).WithoutBurst().Run();
    }

    protected override void OnUpdate()
    {
        
    }

    private void MakeEntityWithDynamicBuffer()
    {
        EntityManager entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
        Entity myEntity = entityManager.CreateEntity();
        entityManager.AddComponentData(myEntity, new Test
        {
            Value = new float3(0, 0, 0)
        });
        entityManager.AddBuffer<PlanetaryOctreeSubNodes>(myEntity);
    }

    private void MakeTestEntity()
    {
        EntityManager entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
        Entity myEntity = entityManager.CreateEntity();
        entityManager.AddComponentData(myEntity, new Test2 
        {
            position = new float3(0,0,0),
            size = 100,
            depth = 5
        });
    }

    private void MakeEntity()
    {
        //EntityManager entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
        //Entity myEntity = entityManager.CreateEntity();
        //entityManager.AddComponentData(myEntity, new Test { Value = new float3(1, 3, 7), TestArray = new NativeArray<float3>(8, Allocator.Temp) {[0] = new float3(0,0,1), [1] = new float3(0,0,2) } });
        //Debug.Log(entityManager.GetComponentData<Test>(myEntity).Value);
    }

    private void CreateEntity()
    {
        EntityManager entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
        Test test = new Test { Value = new float3(1, 3, 7) };
        Entity myEntity = entityManager.CreateEntity();
        entityManager.AddComponentData(myEntity, test);
        Debug.Log(entityManager.GetComponentData<Test>(myEntity).Value);
    }
}
