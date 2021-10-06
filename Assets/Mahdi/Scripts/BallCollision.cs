using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject explosion;
    float delayTime = 2f;

    void OnCollisionStay(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "HittPoints")
        {

            Debug.Log("hit");
            GameObject myExplosion = Instantiate(explosion, transform.position, transform.rotation);
            Destroy(myExplosion, delayTime);
            Destroy(collision.gameObject);
            ScoreManager.instance.AddPoint();
            FindObjectOfType<CreareNewObjects>().CreateNewObject();
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
