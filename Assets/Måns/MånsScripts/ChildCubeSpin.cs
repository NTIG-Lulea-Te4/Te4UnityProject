using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildCubeSpin : MonoBehaviour
{
    float speed;
    public GameObject parentCube;
    // Start is called before the first frame update
    void Start()
    {
        speed = 20;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.RotateAround(parentCube.transform.position, new Vector3(1, 0, 0), speed * Time.deltaTime);
        transform.Rotate(new Vector3(0, 1, 0) * speed * Time.deltaTime, Space.Self);

    }
}
