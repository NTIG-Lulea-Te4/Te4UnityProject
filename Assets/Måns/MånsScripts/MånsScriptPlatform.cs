using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MånsScriptPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float mySpeed = 140;
        float myStationary = 0;

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A was pressed");
            transform.Rotate(new Vector3(1, 0, 0) * mySpeed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.W))
        {

            Debug.Log("W was pressed");
            transform.Rotate(new Vector3(0, 0, -1) * mySpeed * Time.deltaTime);

        }
        
        if (Input.GetKey(KeyCode.S))
        {

            Debug.Log("S was pressed");
            transform.Rotate(new Vector3(0, 0, 1) * mySpeed * Time.deltaTime);

        }
        
        if (Input.GetKey(KeyCode.D))
        {

            Debug.Log("D was pressed");
            transform.Rotate(new Vector3(-1, 0, 0) * mySpeed * Time.deltaTime);

        }
    
    
    }
}
