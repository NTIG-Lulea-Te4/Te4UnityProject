using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rigidbody;
    float fallTime;
    bool sleeping;
    void Start()
    {
        rigidbody = gameObject.AddComponent<Rigidbody>();
        rigidbody.mass = 0.01f;
        Physics.gravity = new Vector3(0, -2.0f, 0);

    }

    // Update is called once per frame
    void Update()
    {


        if (rigidbody.IsSleeping())
        {

            rigidbody.WakeUp();
            Debug.Log("wakeup");

        }


    }
}

