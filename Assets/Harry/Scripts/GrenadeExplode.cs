using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeExplode : MonoBehaviour
{
    public float delay = 3f;
    public float blastRadius = 5f;
    public float force = 50f;
    

    float countDown;
    bool hasExploded = false;
    // Start is called before the first frame update
    void Start()
    {
        countDown = delay;
        
    }

    // Update is called once per frame
    void Update()
    {
        countDown -= Time.deltaTime;
        if (countDown <= 0f && !hasExploded)
        {
            Explode();
            hasExploded = true;
        }
    }

    private void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, blastRadius);

        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rigidbody = nearbyObject.GetComponent<Rigidbody>();
            if (rigidbody != null)
            {
                rigidbody.AddExplosionForce(force, transform.position, blastRadius);
            }
        }

        Destroy(gameObject);
        
    }
}
