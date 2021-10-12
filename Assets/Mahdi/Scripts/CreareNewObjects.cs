using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
public class CreareNewObjects : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject toCreate;
    public GameObject explosionGraphift;
    Vector3 a;
    System.Random random;

    void Start()
    {
        random = new System.Random();
        a = new Vector3((float)random.Next(-4, 4), -0.057f, (float)random.Next(-4, 4));
    }

    public void CreateNewObject()
    {
        Instantiate(toCreate, a, Quaternion.identity);
    }

    
        // Update is called once per frame
        void Update()
        {

        }
   
}