using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueHolder : MonoBehaviour
{

    public int CoinCounter;
    // Start is called before the first frame update
    void Start()
    {
        CoinCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(CoinCounter == 1)
        {
            Debug.Log("ass");
        }
        Debug.Log(CoinCounter);
    }
}
