using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullets : MonoBehaviour
{

    public Transform transform;
    public Rigidbody bullet;
    public float speed;
    public float timer = 0;
    void AddBullet()
    {
        Rigidbody rb;
        rb = Instantiate(bullet, transform.position, transform.rotation);
        rb.velocity = transform.TransformDirection(Vector3.forward * speed);

        Destroy(rb.gameObject, 4);
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
    /*public float speed = 5f;
    public GameObject Bullet;


    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);    
    }




        public int bulletstimmer = 20;
        public List<Vector3> bullets;

        void Update()
        {
            bulletstimmer--;
            if (bulletstimmer <=0)
            {
                bulletstimmer = 60;
                bullets.Add(new Vector3(20, 30, 20));
            }
            for (int i = 0; i < bullets.Count; i++)
            {
                bullets[i] = bullets[i] + new Vector3(10, 0, 0);
            }
        }

        */



