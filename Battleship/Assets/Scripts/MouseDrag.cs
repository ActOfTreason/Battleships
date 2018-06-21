using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour {

    float z = 1;
    [SerializeField]
    private GridSnappingTool gridSnappingTool;
    [SerializeField]
    private Grid grid;

	void OnMouseDrag()
    {


        Vector3 mousePosistion = new Vector3(Input.mousePosition.x, Input.mousePosition.y, z);
        Vector3 objPosistion = Camera.main.ScreenToWorldPoint(mousePosistion);
        //Debug.Log("pos " + objPosistion);
        Vector3 snappedPosistion = gridSnappingTool.GetNearestPointOnGrid(objPosistion);
         //Debug.Log("Snapped " + snappedPosistion);

        transform.position = gridSnappingTool.GetNearestPointOnGrid(objPosistion);
    }



}
