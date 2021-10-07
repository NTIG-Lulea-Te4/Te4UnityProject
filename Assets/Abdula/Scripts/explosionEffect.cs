using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionEffect : MonoBehaviour
{
    [SerializeField]
    private GameObject explosion;

    private Rigidbody myRigidbody;

    [SerializeField]
    private float explosionForce;

    [SerializeField]
    private float radius;

    private Collider[] colliders;

    private void OnCollisionEnter(Collision collision) // normal collison between two objects
    {
        if (collision.collider.CompareTag("TnT")) // collider = the collider we hit
        {
            //Debug.Log("Collided");

            GameObject myExplosion = Instantiate(explosion, transform.position, transform.rotation);
            Destroy(myExplosion, 2);
            knockBack();
            Destroy(collision.gameObject);
            BallHealth.instance.DamageBall();
        }
    }

    void knockBack()
    {
        colliders = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider nearby in colliders)
        {
            myRigidbody = nearby.GetComponent<Rigidbody>();
            if (myRigidbody != null)
            {
                myRigidbody.AddExplosionForce(explosionForce, transform.position, radius);
            }
        }
    }
}
