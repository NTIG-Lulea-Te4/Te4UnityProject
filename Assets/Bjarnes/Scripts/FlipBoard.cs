using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FlipBoard : MonoBehaviour
{


    Transform thisTransform;

    // Start is called before the first frame update
    void Start()
    {
        thisTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {

            transform.Rotate(new Vector3(0, 0, -20 * Time.deltaTime));
            Debug.Log("Left");
        }

        if (Input.GetKey(KeyCode.D))
        {

            transform.Rotate(new Vector3(0, 0, 20 * Time.deltaTime));
            Debug.Log("Left");
        }

        if (Input.GetKey(KeyCode.W))
        {

            transform.Rotate(new Vector3(-20 * Time.deltaTime, 0, 0));
            Debug.Log("Left");
        }

        if (Input.GetKey(KeyCode.S))
        {

            transform.Rotate(new Vector3(20 * Time.deltaTime, 0, 0));
            Debug.Log("Left");
        }
    }
}
