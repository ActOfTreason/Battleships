using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = " Ship", menuName = "Ship")]
public class ShipObject : ScriptableObject {

    public bool[] sizeY0;
    public bool[] sizeY1;
    public bool[] sizeY2;
    //public bool[] sizeY3;
   // public bool[] sizeY4;

    public string ability;

    public int spaces;
    public int remainingSpaces;

    public float xOffset;
    public float yOffset;

    public Sprite ship;
}
