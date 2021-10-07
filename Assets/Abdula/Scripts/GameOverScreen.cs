using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text pointText;

    public void Setup()
    {
        gameObject.SetActive(true);
        Debug.Log("Hit");
    }


}
