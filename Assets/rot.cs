using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rot : MonoBehaviour
{
    public GameObject pivotCube;
    public float rotSpeed;

    void Update()
    {
        transform.RotateAround(pivotCube.transform.position, new Vector3(0,1,0), rotSpeed);
        transform.Rotate(new Vector3(1, 0, 0));
        //transform.position = new Vector3(0, 1, 0)
        //transform.eulerAngles += new Vector3(0, 0, 0);
    }
}
