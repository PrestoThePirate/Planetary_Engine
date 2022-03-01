using Unity.Entities;

//[InternalBufferCapacity(8)]
public struct PlanetaryOctreeSubNodes : IBufferElementData
{
    public Entity Value;
}
