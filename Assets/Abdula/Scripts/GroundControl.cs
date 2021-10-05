using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundControl : MonoBehaviour
{

    [SerializeField] //Lets you modify your variable in inspector regardless if it's private or public.
    private float myForce; 

    [SerializeField] 
    private KeyCode A;

    [SerializeField] 
    private KeyCode D;

    [SerializeField] 
    private KeyCode W;

    [SerializeField]
    private KeyCode S;

    [SerializeField] 
    private KeyCode Space;

    public GroundControl()
    {
        myForce = 0.5f;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(W))
        {
            transform.Rotate(1 * myForce, 0, 0);
        }

        if (Input.GetKey(S))
        {
            transform.Rotate(-1 * myForce, 0, 0);
        }

        if (Input.GetKey(A))
        {
            transform.Rotate(0, 0, 1 * myForce);
        }

        if (Input.GetKey(D))
        {
            transform.Rotate(0, 0, -1 * myForce);
        }

        if (Input.GetKey(Space))
        {
            transform.Rotate(new Vector3(0, 0, 0));
        }
    }
}