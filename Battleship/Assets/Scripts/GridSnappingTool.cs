using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSnappingTool : MonoBehaviour {

    [SerializeField]
    private float size = 1f;

    public Vector3 GetNearestPointOnGrid(Vector3 position)
    {
        position -= transform.position;

        int xCount = Mathf.RoundToInt(position.x / size);
        int yCount = Mathf.RoundToInt(position.y / size);
        int zCount = Mathf.RoundToInt(position.z / size);

        Vector3 result = new Vector3(
            (float)xCount * size,
            (float)yCount * size,
            (float)zCount * size);

        result += transform.position;

        return result;
    }

    public Vector3 GetNearestPointOnGridDragged(Vector3 position)
    {
       // position -= ship.transform.position;
        Debug.Log("pingping");

        int xCount = Mathf.RoundToInt(position.x / size);
        int yCount = Mathf.RoundToInt(position.y / size);
        int zCount = Mathf.RoundToInt(position.z / size);

        Vector3 result = new Vector3(
            (float)xCount * size,
            (float)yCount * size,
            (float)zCount * size);

       // result += ship.transform.position;

        return result;
    }

    /*private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        for (float x = transform.position.x; x < transform.position.x + 10; x += size)
        {
            for (float y = transform.position.y; y < transform.position.y + 10; y += size)
            {
                var point = GetNearestPointOnGrid(new Vector3(x, y, 0f));
                Gizmos.DrawSphere(point, 0.1f);
            }

        }
    }*/
}
