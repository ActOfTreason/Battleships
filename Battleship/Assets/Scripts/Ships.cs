using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ships : MonoBehaviour {

    protected bool[,] size = new bool[3,3];

    public ShipObject shipType;

    private bool[][] arrayOfArrays = new bool[3][];



    // Use this for initialization
    void Start() {
        arrayOfArrays[0] = shipType.sizeY0;
        arrayOfArrays[0] = shipType.sizeY1;
        arrayOfArrays[0] = shipType.sizeY2;
        InitSize(arrayOfArrays);
	}

    private void InitSize(bool[][] arr)
    {
        for (int i = 0; i < size.GetLength(0); i++)
        {
            for (int j = 0; j < size.GetLength(1); j++)
            {
                size[i, j] = arr[i][j];
            }
        }
    }




}
