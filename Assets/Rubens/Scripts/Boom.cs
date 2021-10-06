using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{
    public float delay = 3f;
    float countdown;
    bool hasExploded = false;
    public GameObject explotionEffect;
    public float blastRadius = 5f;
    public float force = 700f;

    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f && !hasExploded)
        {
            Explode();
            hasExploded = true;
        }

        void Explode()
        {
            Instantiate(explotionEffect, transform.position, transform.rotation);

            Collider[] colliders = Physics.OverlapSphere(transform.position, blastRadius);

            foreach (Collider nearbyObject in colliders)
            {
                Rigidbody rigbod = nearbyObject.GetComponent<Rigidbody>();

                if (rigbod != null) 
                {
                    rigbod.AddExplosionForce(force, transform.position, blastRadius);
                }

            }
            explotionEffect.SetActive(false);
            Destroy(gameObject);
        }

    }
}
