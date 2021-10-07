using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float verticalSpeed;
    public float howManyTimesHigherJump;
    

    // Start is called before the first frame update
    void Start()
    {
        if (howManyTimesHigherJump <= 0)
        {
            howManyTimesHigherJump = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {


            transform.position += new Vector3(0,0,1) * verticalSpeed * Time.deltaTime;



        }

        if (Input.GetKey(KeyCode.A))
        {

            transform.position += new Vector3(-1, 0, 0) * verticalSpeed * Time.deltaTime;



        }
        if (Input.GetKey(KeyCode.S))
        {


            transform.position += new Vector3(0, 0, -1) * verticalSpeed * Time.deltaTime;



        }
        if (Input.GetKey(KeyCode.D))
        {


            transform.position += new Vector3(1, 0, 0) * verticalSpeed * Time.deltaTime;


        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * (verticalSpeed * howManyTimesHigherJump) * Time.deltaTime;
        }
    }
}
