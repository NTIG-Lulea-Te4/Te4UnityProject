using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{

    Quaternion startPosistion;
    float speed = 5;
    float xAcel;
    
    float zAcel;
    float rotationX;
    
    float rotationZ;

    // Start is called before the first frame update
    void Start()
    {
        startPosistion = transform.rotation;

        xAcel = 0.04f;
        zAcel = 4;

    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKey(KeyCode.Space))
        //{
            transform.rotation = Quaternion.Lerp(transform.rotation, startPosistion, Time.deltaTime * speed / 10);
        //}

        if (Input.GetKey(KeyCode.W))
        {
            rotationZ = transform.rotation.z;
            if (rotationZ > -20)
            {

                transform.Rotate(0, 0, -zAcel * speed * Time.deltaTime);
                
            }

        }

        if (Input.GetKey(KeyCode.A))
        {
            rotationX = transform.rotation.x;
            if (rotationX < 20)
            {

            transform.Rotate(xAcel, 0, 0 * speed * Time.deltaTime);
                
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            rotationZ = transform.rotation.z;
            if (rotationZ < 20)
            {
                
                transform.Rotate(0, 0, zAcel * speed * Time.deltaTime);

            }

        }
        if (Input.GetKey(KeyCode.D))
        {
            rotationX = transform.rotation.x;
            if (rotationX > -20)
            {

                transform.Rotate(-xAcel, 0, 0 * speed * Time.deltaTime);

            }
        }
    }
}
