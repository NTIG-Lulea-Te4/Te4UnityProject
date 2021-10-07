using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueHolder : MonoBehaviour
{

    public static int coinCounter;
    // Start is called before the first frame update
    void Start()
    {
        coinCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(coinCounter == 1)
        {
            Debug.Log("ass");
        }
        Debug.Log(coinCounter);
    }
}
