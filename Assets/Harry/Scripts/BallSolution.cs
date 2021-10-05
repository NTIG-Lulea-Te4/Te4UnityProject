using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSolution : MonoBehaviour
{
    float speed =  0.01f;
    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(Vector3.up * speed);
    }
}
