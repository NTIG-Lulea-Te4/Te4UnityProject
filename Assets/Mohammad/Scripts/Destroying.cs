using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroying : MonoBehaviour
{
    public static int theScore;
    public GameObject ScoreText;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("target"))
        {
            theScore += 1;
            Destroy(collision.gameObject);
        }
    }
    void Update()
    {
        ScoreText.GetComponent<Text>().text = "Score: " + theScore;
    }
}

