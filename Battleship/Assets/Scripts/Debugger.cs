using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugger : MonoBehaviour {

    public void print2DBoolArray(bool[,] array)
    {
        string final = "";
        for (int i = array.GetLength(0)-1; i > -1; i--)
        {

            if (i != array.GetLength(0) - 1)
            {
                final += "\n \n     ";
            } else
            {
                final += "     ";
            }

            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == true)
                {
                    final += " O ";
                }
                else
                {
                    final += " X ";
                }

            }

        }
        Debug.Log("Clikc on the the nexxt line in console to see");
        Debug.Log(final);
       // Debug.Log("end \n");
    }
}
