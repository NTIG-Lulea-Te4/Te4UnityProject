using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{

    public GameObject bulletSpawn;
    public GameObject bullet;
    Rigidbody bulletRigidbody;

    void Start()
    {
        
    }

    
    void Update()
    {

        if (Input.GetKey(KeyCode.Mouse0))
        {
            //initiera/skapar skotten
            //Anv�nder Bulletspawn som �r ett object i armen/pistolen som reffrence vart vi ska skapa den
            GameObject tempBullet;
            tempBullet = Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation) as GameObject;

            //L�gger p� kraft p� bullets som skapas
            bulletRigidbody = tempBullet.GetComponent<Rigidbody>();
            bulletRigidbody.AddForce(new Vector3(10, 0, 10));

            //tar bort skotten efter 5 sekunder
            Destroy(tempBullet, 5f);
        }

    }
}
