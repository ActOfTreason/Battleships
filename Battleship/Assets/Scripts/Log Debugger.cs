using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogDebugger : MonoBehaviour {

	

    public void print2DBoolArray(bool[,] array)
    {
        string final = "";
        for (int i = 0; i < array.GetLength(0); i++)
        {
            final += "/n";
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if(array[i,j] == true)
                {
                    final += "O";
                }
                else
                {
                    final += "X";
                }
            }

        }
        Debug.Log("The board looks like this:");
        Debug.Log(final);
        Debug.Log("end /n");
    }
}
