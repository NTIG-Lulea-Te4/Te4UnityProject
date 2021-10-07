using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBullet : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 150f;
    //public int bulletTimer = 120;
    public float bulletPersec = 20;



    void Update()
    {
        bulletPersec--;
        if (bulletPersec < 0)
        {


            GameObject bullets = Instantiate(bullet, transform.position, transform.rotation);
            Rigidbody rb = bullets.GetComponent<Rigidbody>();
            rb.AddForce(Vector3.forward * speed);
        }
        


        Destroy(bullet.gameObject, 3);

    }
}
