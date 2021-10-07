using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
    public ValueHolder coinAmount;
    int pickedUpCoins;
    
    // Start is called before the first frame update
    void Start()
    {  
        pickedUpCoins = coinAmount.CoinCounter;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Sphere"))
        {
            pickedUpCoins = coinAmount.CoinCounter + 1;
            coinAmount.CoinCounter = pickedUpCoins;

            Debug.Log("You got a coin");
            Destroy(gameObject);
        }
        

    }
}
