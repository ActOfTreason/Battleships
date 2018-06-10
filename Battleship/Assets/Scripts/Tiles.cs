using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Tiles : MonoBehaviour {


    Tilemap tilemap;
    Tilemap ships;
    Transform test;
    public GameObject debugShip;
    TileBase[] gameBoard;
    // Use this for initialization
    void Start()
	{
		tilemap = GetComponentInChildren<Tilemap> ();
        //tilemap = GetComponentInChildren<Tilemap>();
        test = this.gameObject.transform.GetChild(2);
        ships = test.GetComponent<Tilemap> ();
        tilemap.CompressBounds();
		BoundsInt bounds = tilemap.cellBounds;
		TileBase[] allTiles = tilemap.GetTilesBlock(bounds);

        //debug test ekki gera gameboardid svona
        gameBoard = tilemap.GetTilesBlock(bounds);

		for (int x = 0; x < bounds.size.x; x++) {
			for (int y = 0; y < bounds.size.y; y++) {
				TileBase tile = allTiles [x + y * bounds.size.x];
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

		if (Input.GetMouseButtonDown (0)) {
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int cell = ships.WorldToCell(worldPos);
            Debug.Log(cell);
            Vector3 cellPos = ships.GetCellCenterWorld(cell) + new Vector3(0f, 0.5f, 1.5f);
            TileBase selectedTile = gameBoard[(cell.x + 5) + (5 + cell.y) * tilemap.cellBounds.size.x];
            Debug.Log(selectedTile.name);
            

            Instantiate(debugShip, cellPos, Quaternion.identity);
        }



	}
}
