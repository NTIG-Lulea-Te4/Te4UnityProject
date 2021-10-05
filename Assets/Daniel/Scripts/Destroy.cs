using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    public GameObject explosion;
    public float expForce;
    public float radius;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            GameObject explosion1 = Instantiate(explosion, transform.position, transform.rotation);
            Destroy(explosion1, 2);
            Destroy(collision.gameObject);
            PoangCounting.poang += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
