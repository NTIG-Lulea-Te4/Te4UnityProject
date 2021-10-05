using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    float rotationValueZAxis;
    float rotationValueXAxis;

    // Start is called before the first frame update
    void Start()
    {
        rotationValueZAxis = 20;
        rotationValueXAxis = 20;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {

            transform.Rotate(new Vector3(0, 0, rotationValueZAxis) * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.S))
        {

            transform.Rotate(new Vector3(0, 0, rotationValueZAxis * -1) * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(rotationValueXAxis * -1, 0, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(rotationValueXAxis, 0, 0) * Time.deltaTime);
        }
    }
}
