using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakeUp : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rigidbody;
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        if (rigidbody.IsSleeping() == true)
        {
            rigidbody.WakeUp();
            Debug.Log("wakeup");
        }
    }
}
