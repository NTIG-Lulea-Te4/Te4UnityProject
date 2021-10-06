using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform transform;
    public GameObject gameObject;
    public Rigidbody rigidbody;
    public float velocity  = 9;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
            //Quaternion.identity is the defual rotation for my Objects rotation
            //GameObject bullet;
            //bullet = Instantiate(gameObject, transform.position, transform.rotation);
            //bullet.velocity = transform.TransformDirection(Vector3.forward*50);
    }
    void CreateBulltet(int bulletsToMakes)
    {
        for (int i = 0; i < bulletsToMakes; i++)
        {
            Instantiate(gameObject, new Vector3(transform.position.x, transform.position.y, transform.position.z*2), Quaternion.identity);
            Rigidbody bullets;
            bullets = Instantiate(rigidbody, transform.position, transform.rotation);
            bullets.velocity = transform.TransformDirection(Vector3.forward*velocity);
        }
    }
    void CreateBullet()
    {
        //Instantiate(gameObject, new Vector3(transform.position.x, transform.position.y, transform.position.z * 2), Quaternion.identity);
        Rigidbody bullets;
        bullets = Instantiate(rigidbody, transform.position, Quaternion.identity);
        bullets.velocity = transform.TransformDirection(Vector3.forward * velocity);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5)
        {
            CreateBullet();
            timer = 0;
        }

    }
}
