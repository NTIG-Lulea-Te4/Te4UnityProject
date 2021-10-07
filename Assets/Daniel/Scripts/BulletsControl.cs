using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsControl : MonoBehaviour
{
    //public static GameObject bullet;
    public Transform transform;
    //public GameObject gameObject;
    public Rigidbody rigidbody;
    float myVelocity = 1000.0f;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void CreatBullets()
    {
        
        var bullet = Instantiate(rigidbody, transform.position, transform.rotation);
        //bulletsToMake.velocity = transform.TransformDirection(Vector3.forward * myVelocity);
        bullet.AddForce(transform.forward * myVelocity);
    }
    //public  void CreateBullets( Vector3 spawnPosition)
    //{
    //    Instantiate(gameObject.transform, spawnPosition, Quaternion.identity);
    //}
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.1f)
        {
            CreatBullets();
        timer = 0;

    }
}
    //    public static void CreatBullet(Vector3 spawnPosition)
    //    {
    //        Instantiate(bullet, spawnPosition, Quaternion.identity);
    //    }
}
