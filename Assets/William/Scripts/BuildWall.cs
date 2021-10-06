using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildWall : MonoBehaviour
{
    public GameObject spawnInWall;


    private void Start()
    {
        spawnInWall.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {

        spawnInWall.SetActive(true);
    }
}
