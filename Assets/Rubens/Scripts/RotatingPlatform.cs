using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    public Vector3 currentRotation;
    //stores x,y and z values.

    Quaternion startPosistion;
    int speed;

    // Start is called before the first frame update
    void Start()
    {
        startPosistion = transform.rotation;
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, startPosistion, Time.deltaTime * speed / 10);


        currentRotation = GetComponent<Transform>().eulerAngles;
        //current rotation, what is the current rotation? eulerAngles.

        if ((Input.GetAxis("Horizontal") > .1) && (currentRotation.z <= 9 || currentRotation.z >= 351)) // gå bara mellan 351° och 9° dvs 351 - 360, 0(360) - 9.
        {
            transform.Rotate(0, 0, -.1f);
        }

        if ((Input.GetAxis("Horizontal") < -.1) && (currentRotation.z >= 350 || currentRotation.z <= 8))
        {
            transform.Rotate(0, 0, .1f);
        }

        if ((Input.GetAxis("Vertical") > .1) && (currentRotation.x <= 8 || currentRotation.x >= 350))
        {
            transform.Rotate(.1f, 0, 0);
        }

        if ((Input.GetAxis("Vertical") < -.1) && (currentRotation.x >= 351 || currentRotation.x <= 9))
        {
            transform.Rotate(-.1f, 0, 0);
        }


    }
}
