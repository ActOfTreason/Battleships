using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Tiles : BoardController {


    Tilemap tilemap;
    Tilemap ships;
    Transform test;
    public GameObject debugShip;
    private GridSnappingTool gridSnappingTool;

    void Awake() {
        gridSnappingTool = FindObjectOfType<GridSnappingTool>();
    }


    void Start()
	{
		tilemap = GetComponentInChildren<Tilemap> ();
        //tilemap = GetComponentInChildren<Tilemap>();
        test = this.gameObject.transform.GetChild(2);
        ships = test.GetComponent<Tilemap> ();
        tilemap.CompressBounds();
		BoundsInt bounds = tilemap.cellBounds;
        //gameBoard = new TileBase[bounds.size.x, bounds.size.y];
		TileBase[] allTiles = tilemap.GetTilesBlock(bounds);

        //debug test ekki gera gameboardid svona
        //gameBoard = tilemap.GetTilesBlock(bounds);

		for (int x = 0; x < bounds.size.x; x++) {
			for (int y = 0; y < bounds.size.y; y++) {
				TileBase tile = allTiles [x + y * bounds.size.x];
                //stillum þennan reit sem tóman
                gameBoard[x , y] = false;
				if (tile != null) {
					//Debug.Log("x:" + x + " y:" + y + " tile:" + tile.name);
				} else {
					//Debug.Log("x:" + x + " y:" + y + " tile: (null)");
				}
			}
		}
	}

	// Update is called once per frame
	void Update()
	{
        //Gamla
        /*if (Input.GetMouseButtonDown (0)) {
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int cell = ships.WorldToCell(worldPos);
            Debug.Log(cell);
            Vector3 cellPos = ships.GetCellCenterWorld(cell) + new Vector3(0f, 0.5f, 1.5f);
            //TileBase selectedTile = gameBoard[(cell.x + 5) + (5 + cell.y) * tilemap.cellBounds.size.x];
            TileBase selectedTile = gameBoard[cell.x +5 , cell.y + 5];
            Debug.Log(selectedTile.name);
            
            
            Instantiate(debugShip, cellPos, Quaternion.identity);
        }*/

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition) , Vector2.zero);

            if (hit)
            {
                PlaceCubeNear(hit.point);
            }
        }

    }

    private void PlaceCubeNear(Vector3 clickPoint)
    {
        Vector3 finalPosition = gridSnappingTool.GetNearestPointOnGrid(clickPoint);
        finalPosition.z = 1;
        int xTest = (int) (Math.Floor(finalPosition.x)) + 5;
        int yTest = (int)(Math.Floor(finalPosition.y)) + 5;
        Debug.Log("hnitin eru x: " + xTest + " y: " + yTest);

        if(!gameBoard[xTest,yTest])
        {
            //GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = finalPosition;
            Instantiate(debugShip, finalPosition, Quaternion.identity);
            ChangeOccupiedTile(xTest, yTest);
        } else
        {
            Debug.Log("Aah Aah Aah nononon");
        }
        


       
    }
}
