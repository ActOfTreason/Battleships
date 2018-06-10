using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BoardController : MonoBehaviour {

    //protected TileBase[,] gameBoard = new TileBase[10,10];
    protected bool[,] gameBoard = new bool[10, 10];



    protected void ChangeOccupiedTile(int x, int y)
    {
        gameBoard[x, y] = !gameBoard[x, y];
    }

	
}
