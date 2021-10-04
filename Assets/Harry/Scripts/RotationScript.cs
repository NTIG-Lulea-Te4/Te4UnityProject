using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{

    float accelx;
    float accely;
    float accelz;
    // Start is called before the first frame update
    void Start()
    {
        accelx = Input.acceleration.x;
        accely = Input.acceleration.y;
        accelz = Input.acceleration.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            
            transform.Rotate(accelx * Time.deltaTime, accely * Time.deltaTime, accelz * Time.deltaTime);
        }
    
        if (Input.GetKey(KeyCode.A))
        {

        }
        if (Input.GetKey(KeyCode.S))
        {

        }
        if (Input.GetKey(KeyCode.D))
        {

        }
    }
}
