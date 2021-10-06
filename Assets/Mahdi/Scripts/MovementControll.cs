using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControll : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;

    public float ForwardForce;
    public float SideForce;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(SideForce * Time.deltaTime,0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(-SideForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, ForwardForce * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -ForwardForce * Time.deltaTime);
        }
    }
}
