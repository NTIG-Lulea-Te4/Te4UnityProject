using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWall : MonoBehaviour
{
    void OnTriggerEnter(Collision collision)
    {

        if (collision.gameObject.name == "Player")
        {

            Debug.Log("Has collided");
        }

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
