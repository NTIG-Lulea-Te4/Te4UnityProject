using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsControl : MonoBehaviour
{
    //public static GameObject bullet;
    public Transform transform;
   
    public Rigidbody rigidbody;
    float myVelocity = 1.0f;
    float timer = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void CreatBullets()
    {
        Rigidbody bulletsToMake = Instantiate(rigidbody, transform.position, Quaternion.identity);
        bulletsToMake.velocity = transform.TransformDirection(Vector3.forward * myVelocity);
    }
    // Update is called once per frame
    void Update()
    {
        
        while (timer != 0)
        {
            CreatBullets();
            timer -= Time.deltaTime;
        }
    }
    //public static void CreatBullet(Vector3 spawnPosition)
    //{
    //    Instantiate(bullet, spawnPosition, Quaternion.identity);
    //}
}
