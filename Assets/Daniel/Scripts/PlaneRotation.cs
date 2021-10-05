using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneRotation : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 30.0f;
    [SerializeField]
    KeyCode keyPositionUpward;
    [SerializeField]
    KeyCode keyPositionRight;
    [SerializeField]
    KeyCode keyPositionDownward;
    [SerializeField]
    KeyCode keyPositionLeft;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(keyPositionUpward))
        {

            transform.Rotate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(keyPositionRight))
        {

            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(keyPositionDownward))
        {

            transform.Rotate(Vector3.forward * -speed * Time.deltaTime);
        }
        if (Input.GetKey(keyPositionLeft))
        {

            transform.Rotate(Vector3.left * -speed * Time.deltaTime);
        }
    }
}
