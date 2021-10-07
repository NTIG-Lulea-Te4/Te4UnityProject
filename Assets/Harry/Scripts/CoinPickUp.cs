using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
    
    
    
    // Start is called before the first frame update
    void Start()
    {  
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Sphere"))
        {

            ValueHolder.coinCounter++;

            Debug.Log("You got a coin");
            Destroy(gameObject);
        }
        

    }
}
