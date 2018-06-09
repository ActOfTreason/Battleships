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
        Debug.Log("this " + allTiles);

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
			Vector3 pos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Debug.Log ("x: " + pos.x + "y; " + pos.y);
            //Vector3Int posis = new Vector3Int((int)Math.Floor(pos.x), (int)(Math.Floor(pos.y) - 0.5), 1);
            Vector3Int posis = new Vector3Int((int)pos.x, (int)(Math.Floor(pos.y) - 0.5), 1);
            Debug.Log(posis);
            TileBase CLickedTile = tilemap.GetTile(posis);
            Debug.Log("the tile " + CLickedTile);
            TileBase spawnTile = ships.GetTile(posis);
            Instantiate(debugShip, posis, Quaternion.identity);
		}



	}
}
