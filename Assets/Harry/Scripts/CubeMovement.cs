using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    float speed = 5;
    float xAcel;
    float zAcel;

    // Start is called before the first frame update
    void Start()
    {
        xAcel = 2;
        zAcel = 200;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            
            
                transform.Rotate(0, 0, -zAcel * speed * Time.deltaTime);

            

        }

        if (Input.GetKey(KeyCode.A))
        {
           

                transform.Rotate(xAcel, 0, 0 * speed * Time.deltaTime);

            
        }
        if (Input.GetKey(KeyCode.S))
        {
            

                transform.Rotate(0, 0, zAcel * speed * Time.deltaTime);

            

        }
        if (Input.GetKey(KeyCode.D))
        {
            

                transform.Rotate(-xAcel, 0, 0 * speed * Time.deltaTime);

            
        }
    }
}
