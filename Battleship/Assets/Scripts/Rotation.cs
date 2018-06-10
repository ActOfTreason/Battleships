using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

    public GameObject target;
    private Vector3 zAxis = new Vector3(0, 0, 1);
    private bool isHorizontal;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isHorizontal)
        {
            ChangeRotation(90);
            isHorizontal = false;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && !isHorizontal)
        {
            ChangeRotation(-90);
            isHorizontal = true;
        }
    }

    void ChangeRotation(int rotationWay)
    {
        //transform.RotateAround(target.position, 1);
        //transform.Rotate(Vector3.forward * -90);
        transform.Rotate(Vector3.forward * rotationWay, Space.World);
    }
}
