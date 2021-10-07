using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingTheTower : MonoBehaviour
{
    // Start is called before the first frame update
    public bool rotation;
    public float rotateAmount = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotation)
        {
            transform.Rotate(Vector3.up * rotateAmount);
        }
    }
}
