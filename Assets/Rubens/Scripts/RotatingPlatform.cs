using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    public Vector3 currentRotation;
    //stores x,y and z values.



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        currentRotation = GetComponent<Transform>().eulerAngles;
        //current rotation, what is the current rotation? eulerAngles.
        if (Input.GetKey("up"))
        {


            if ((Input.GetAxis("Horizontal") > .1) && (currentRotation.z <= 9 || currentRotation.z >= 351)) // gå bara mellan 351° och 9° dvs 351 - 360, 0(360) - 9.
            {
                transform.Rotate(0, 0, -.1f);
            }

        }
        else
        {
            while(currentRotation !<= 0)
            {
                transform.Rotate(0, 0, .1f);
            } // https://www.codegrepper.com/code-examples/csharp/How+to+hold+key+down+unity

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
