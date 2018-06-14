using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ships : MonoBehaviour {

    protected bool[,] size = new bool[3,3];

    public ShipObject shipType;

    private bool[][] arrayOfArrays = new bool[3][];

    [SerializeField]
    private GridSnappingTool gridSnappingTool;

    [SerializeField]
    private Tiles tile;


    // Use this for initialization
    void Start() {
        arrayOfArrays[0] = shipType.sizeY0;
        arrayOfArrays[1] = shipType.sizeY1;
        arrayOfArrays[2] = shipType.sizeY2;
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


    /// <summary>
    /// Gives the location in the grid of the ship
    /// TODO: the offset is hard coded for now
    /// </summary>
    /// <returns>Vector 3 with x and y being the coordinates in the grid</returns>
    public Vector3 GetShipLocation()
    {
        Vector3 location = this.transform.position;

        location = gridSnappingTool.GetNearestPointOnGrid(location);

        location.x += 4.5f;
        location.y += 4.5f;
        Debug.Log("getshipLocation gefur " + location);

        return location;


    }

    void OnMouseDown() {

        Debug.Log("'ytt a takka");

        

        GetShipLocation();
        //Debug.Log(shipType.ability);
    }




}
