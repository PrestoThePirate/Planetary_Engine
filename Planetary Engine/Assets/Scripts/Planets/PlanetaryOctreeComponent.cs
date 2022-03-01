using Unity.Entities;
using Unity.Mathematics;

[GenerateAuthoringComponent]
public struct PlanetaryOctreeComponent : IComponentData
{
    public PlanetaryOctreeNode node;

    public float size; //200000
    public int depth; //12500
}