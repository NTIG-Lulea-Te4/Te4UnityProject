using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroying : MonoBehaviour
{
    public static float theScore;
    public GameObject ScoreText;
    public float radius;
    public float force = 500f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("target"))
        {
            theScore += 1;
            Destroy(collision.gameObject);
        }
        
        /*if (collision.gameObject.tag.Equals("theBomb"))
        {
            Destroy(collision.gameObject);

            Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
            foreach (Collider nearbyObject in colliders)
            {
                Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.AddExplosionForce(force, transform.position, radius);
                }
            }
        }*/
    }
    void Update()
    {
        ScoreText.GetComponent<Text>().text = "Score: " + theScore;
    }
}

