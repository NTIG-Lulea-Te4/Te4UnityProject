using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{

    public GameObject explotion;
    public float radius;
    public float force;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Destroy(gameObject);
            Explode();
            knockBack();
            

        }
    }
    // Update is called once per frame
    void Explode ()
    {
        Instantiate (explotion,new Vector3( transform.position.x, transform.position.y + 4, transform.position.z), transform.rotation);
        
    }

    void knockBack()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(force, transform.position, radius);
            }
        }
    }
}
