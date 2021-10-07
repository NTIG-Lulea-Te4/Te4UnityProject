using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    public GameObject explosion;
    public float expForce;
    public float radius;
    public GameObject sample;
    public int xPosition;
    public int zPosition;
    public int ObjectQuantity;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        

        if (collision.gameObject.tag.Equals("Bullet"))
        {
            GameObject explosion1 = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(explosion1, 0.5f);
            KnockBack();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            //GameObject explosion1 = Instantiate(explosion, transform.position, Quaternion.identity);
            //Destroy(explosion1, 0.5f);
            Destroy(collision.gameObject);
            Debug.Log("Hit");
            PoangCounting.score += 1;
            StartCoroutine(CreateObjects());
        }
    }

    //Update is called once per frame

    IEnumerator CreateObjects()
    {

        xPosition = Random.Range(-10, 10);
        zPosition = Random.Range(-10, 10);
        Instantiate(sample, new Vector3(xPosition, 20, zPosition), Quaternion.identity);
        yield return new WaitForSeconds(1);

    }
    void KnockBack()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider i in colliders)
        {
            Rigidbody rigidbody = i.GetComponent<Rigidbody>();
            if(rigidbody != null)
            {
                rigidbody.AddExplosionForce(expForce, transform.position, radius);
            }
        }
    }
    void Update()
    {
        
    }
}
