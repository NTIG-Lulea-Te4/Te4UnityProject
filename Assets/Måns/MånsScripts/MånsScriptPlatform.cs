using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MånsScriptPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 myPosition = GameObject.Find("Platform").transform.position;
        float mySpeed = 5;
        float myStationary = 0;
        
    }

    // Update is called once per frame
    void Update(Vector3 myPos, float speed, float stay)
    {
        
        
        if (Input.GetKey(KeyCode.A))
        {
            myPos = myPos;        

        }

        if (Input.GetKey(KeyCode.W))
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
