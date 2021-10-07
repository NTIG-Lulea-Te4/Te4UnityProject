using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnEnter : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Heal Box"))
        {
            //Debug.Log("HIT");
            if (BallHealth.instance.hearts < BallHealth.instance.maxHearts)
            {
                BallHealth.instance.HealBall();
                Destroy(other.gameObject);
            }
        }
    }
}