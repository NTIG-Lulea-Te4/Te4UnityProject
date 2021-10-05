using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    [SerializeField] 
    private float ballSpeed;

    [SerializeField] 
    KeyCode rightArrow;

    [SerializeField] 
    KeyCode leftArrow;

    [SerializeField]
    KeyCode upArrow;

    [SerializeField] 
    KeyCode downArrow;

    [SerializeField]
    KeyCode Reset;

    public BallControl()
    {
        ballSpeed = 1.0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(rightArrow))
        {
            transform.position += ballSpeed * Vector3.right;
        }

        if (Input.GetKey(leftArrow))
        {
            transform.position +=  ballSpeed * Vector3.left;
        }

        if (Input.GetKey(upArrow))
        {
            transform.position +=  ballSpeed * Vector3.forward;
        }

        if (Input.GetKey(downArrow))
        {
            transform.position +=  ballSpeed * Vector3.back;
        }

        if (Input.GetKey(Reset))
        {
            transform.position = new Vector3(0, 1, 0);
        }
    }
}
