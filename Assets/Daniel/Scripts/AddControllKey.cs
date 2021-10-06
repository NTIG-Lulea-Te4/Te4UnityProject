using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddControllKey : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Vector3 v3ForceX;
    [SerializeField]
    Vector3 v3ForceY;
    [SerializeField]
    Vector3 v3ForceZ;
    [SerializeField]
    KeyCode keyPositiveX;
    [SerializeField]
    KeyCode keyNegativeX;
    [SerializeField]
    KeyCode keyPositiveZ;
    [SerializeField]
    KeyCode keyNegativeZ;
    [SerializeField]
    KeyCode keyPositiveY;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(keyPositiveX))
        {
            GetComponent<Rigidbody>().velocity += v3ForceX;
        }
        if (Input.GetKey(keyNegativeX))
        {
            GetComponent<Rigidbody>().velocity -= v3ForceX;
        }
        if (Input.GetKey(keyPositiveZ))
        {
            GetComponent<Rigidbody>().velocity += v3ForceZ;
        }
        if (Input.GetKey(keyNegativeZ))
        {
            GetComponent<Rigidbody>().velocity -= v3ForceZ;
        }
        if (Input.GetKey(keyPositiveY))
        {
            GetComponent<Rigidbody>().velocity += v3ForceY;
        }


    }
}