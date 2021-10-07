using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CollectingPoint : MonoBehaviour
{
    public int theScore;
    //public GameObject ScoreText;
    public float radius;
    public  TextMeshPro scoreUI;



    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("target"))
        {
            Destroy(collision.gameObject);
            theScore += 1;

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
        scoreUI.text = "Score: " + theScore.ToString();

        //ScoreText.GetComponent<Text>().text = "Score: " + theScore;

    }

}

