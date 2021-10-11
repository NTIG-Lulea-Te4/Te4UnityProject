using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float rotateSpeed;

    void Update()
    {
        //transform.eulerAngles += new Vector3(0, 1, 0);
        transform.Rotate(0, rotateSpeed, 0);
        //Transform Cube = transform.Find("RotCube");
        //Cube.Rotate(1, 0, 0);
    }
}
