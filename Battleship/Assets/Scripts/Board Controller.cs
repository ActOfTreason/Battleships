using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BoardController : MonoBehaviour {

    //protected TileBase[,] gameBoard = new TileBase[10,10];
    protected bool[,] gameBoard = new bool[10, 10];
    protected Ships[,] shipsOnBoard = new Ships[10, 10];

    public Debugger debbuger;



    protected void ChangeOccupiedTile(int x, int y)
    {
        gameBoard[x, y] = !gameBoard[x, y];
        PrintArray();
    }

    protected void DestroyShipOnTile(int x, int y)
    {
        Destroy(shipsOnBoard[x,y]);
        //shipsOnBoard.RemoveAt(x, y);
    }



    /// <summary>
    /// calls a function in the debbuger that prints a 2d boolean array
    /// </summary>
    public void PrintArray()
    {
        debbuger.print2DBoolArray(gameBoard);
    }


    /// <summary>
    /// Gets the location and the ship that is being placed
    /// and uses that to update the gameboard
    /// </summary>
    /// <param name="x"> int, the cell clicked </param>
    /// <param name="y"></param>
    /// <param name="ship"></param>
    protected void PlaceShip(int x, int y, Ships ship)
    {

    }


}
