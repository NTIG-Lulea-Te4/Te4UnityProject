using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveWall : MonoBehaviour
{

    public GameObject removeAbleWall;
    public GameObject forTesting;

    private void Start()
    {
        removeAbleWall.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {

            forTesting.SetActive(false);

        }
    }

    private void OnTriggerEnter(Collider other)
    {

        removeAbleWall.SetActive(false);

    }

}
