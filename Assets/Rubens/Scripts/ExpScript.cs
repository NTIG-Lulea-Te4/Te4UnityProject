using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpScript : MonoBehaviour
{
    float timeToLive;
    // Start is called before the first frame update
    void Start()
    {
        timeToLive = 2;
    }

    // Update is called once per frame
    void Update()
    {
        timeToLive -= Time.deltaTime;
        if (timeToLive < 0)
        {
            Destroy(this.gameObject);
        }
    }
}
