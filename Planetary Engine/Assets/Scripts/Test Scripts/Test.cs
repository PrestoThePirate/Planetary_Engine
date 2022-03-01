using Unity.Collections;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

public class Test : IComponentData
{

    public float3 Value;

    public NativeList<float3> TestList;
}
