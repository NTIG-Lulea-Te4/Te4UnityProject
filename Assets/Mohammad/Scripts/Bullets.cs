using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullets : MonoBehaviour
{

    //public Transform transform;
    public Rigidbody bullet;
    public float speed;
    public float timer = 0;
    void AddBullet()
    {
        Rigidbody rb;
        rb = Instantiate(bullet, transform.position, transform.rotation);
        rb.velocity = transform.TransformDirection(Vector3.forward * speed);

        Destroy(rb.gameObject, 2);

       /* 
        GameObject bullets = Instantiate(bullet, transform.position, transform.rotation);
        Rigidbody rb = bullets.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * speed);
       */
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 2)
        {
            AddBullet();
            timer = 0;
        }
       
    }


}


