using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Tiles : MonoBehaviour {


    Tilemap tilemap;
    // Use this for initialization
    void Start()
	{
		tilemap = GetComponent<Tilemap> ();
		tilemap.CompressBounds();
		BoundsInt bounds = tilemap.cellBounds;
		TileBase[] allTiles = tilemap.GetTilesBlock(bounds);

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
            Vector3Int posis = new Vector3Int((int)Math.Floor(pos.x), (int)Math.Floor(pos.y), 0);
            TileBase CLickedTile = tilemap.GetTile(posis);
            Debug.Log("the tile " + CLickedTile);
		}



	}
}
