using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotCollision : MonoBehaviour
{

    public GameObject gameObject;
    public GameObject explosion;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject myExplosion = Instantiate(explosion, transform.position, transform.rotation);
            Destroy(myExplosion, 2);
            Destroy(collision.gameObject);
            DestroyImmediate(collision.gameObject);
            FindObjectOfType<GameManager>().GameOver();

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
