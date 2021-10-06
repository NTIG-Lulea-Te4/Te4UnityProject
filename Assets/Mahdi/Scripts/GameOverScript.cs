using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public Text scoreText;

    public void SetUp(int score)
    {
        gameObject.SetActive(true);
        scoreText.text = "Points " + score.ToString() + ":";
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
