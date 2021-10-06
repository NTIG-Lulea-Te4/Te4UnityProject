using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision) // normal collison between two objects
    {
        if (collision.collider.CompareTag("Point Box")) // collider = the collider we hit
        {
            //Debug.Log("Collided");
            Destroy(collision.gameObject);
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Obstacle"))
    //    {
    //        Debug.Log("Collided");
    //        Destroy(other.gameObject);
    //    }
    //}
}
