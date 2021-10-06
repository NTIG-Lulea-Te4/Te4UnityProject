using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject bulletPrefab;
    float speed = 20f;
    public Rigidbody ass;

    

    private void Start()
    {
       
    }
    void Update()
    {

        if (Input.GetKey(KeyCode.O))
        {
            ass.velocity = transform.right * speed;
            Shoot();
                
        }
    }

    void Shoot()
    {
       
       Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
        
    }
}
