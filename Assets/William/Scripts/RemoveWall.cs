using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveWall : MonoBehaviour
{

    public GameObject removeAbleWall;

    private void OnTriggerEnter(Collider other)
    {

        removeAbleWall.SetActive(false);

    }

}
