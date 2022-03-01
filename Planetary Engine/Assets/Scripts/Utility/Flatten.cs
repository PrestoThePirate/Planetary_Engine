using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

namespace Utility
{
    public static class Flatten<TType>
    {
        /// <summary>
        /// Pass in a 3D array and get an outputed 1D array.
        /// </summary>
        public static TType[] Flatten3DArray(TType[,,] array)
        {
            int width = array.GetLength(0);
            int height = array.GetLength(1);
            int depth = array.GetLength(2);

            TType[] FlattenedArray = new TType[width * height * depth];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    for (int z = 0; z < depth; z++)
                    {
                        FlattenedArray[x + height * (y + depth * z)] = array[x, y, z];
                    }
                }
            }

            return FlattenedArray;

        }

        /// <summary>
        /// Pass in a 1D array with dimensions and index coordinates that you want to read, and get the output of a 3D array.
        /// </summary>
        public static TType ReadFlattenedArray(TType[] flattenedArray, int3 dimensions, int3 index)
        {
            return flattenedArray[index.x + dimensions.y * (index.y + dimensions.z * index.z)];
        }

        /// <summary>
        /// Pass in a 1D array with dimensions and index coordinates and set the value of a 3D array in the 1D array.
        /// </summary>
        public static void WriteToFlattenedArray(TType[] flattenedArray, int3 dimensions, int3 index, TType Value)
        {
            flattenedArray[index.x + dimensions.y * (index.y + dimensions.z * index.z)] = Value;
        }

    }
}
    
