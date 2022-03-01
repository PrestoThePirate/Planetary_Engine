using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

public class Test2 : IComponentData
{

    public float3 position;
    public Entity entity;
    public float size;
    public int depth;

}
