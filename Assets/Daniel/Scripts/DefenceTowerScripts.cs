using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenceTowerScripts : MonoBehaviour
{
    private Vector3 shootPosition;
    private void Awake()
    {
        shootPosition = transform.Find("ShootPosition").position;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
