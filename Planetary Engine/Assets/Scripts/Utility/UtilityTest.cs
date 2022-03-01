using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class UtilityTest : MonoBehaviour
{

    int[,,] VectorArray = new int[16,16,16];

    private void Start()
    {
        for (int x = 0; x < VectorArray.GetLength(0); x++)
        {
            for (int y = 0; y < VectorArray.GetLength(1); y++)
            {
                for (int z = 0; z < VectorArray.GetLength(2); z++)
                {
                    VectorArray[x, y, z] = UnityEngine.Random.Range(0, 10);
                }
            }
        }

        int[] FlattenedArray = Utility.Flatten<int>.Flatten3DArray(VectorArray);

        for (int i = 0; i < FlattenedArray.Length; i++)
        {
            Debug.Log(FlattenedArray[i]);
        }
    }

}
