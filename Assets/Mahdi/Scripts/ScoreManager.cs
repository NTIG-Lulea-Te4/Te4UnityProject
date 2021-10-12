using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    Text scoreText;
    Text highScore;

    int scoreCounter = 0;
    int highScoreCounter = 0;
    // Start is called before the first frame update
    // public void Dead()
    //{
    //    restart.SetActive(true);

    //    scoreText.text = "Points " + score.ToString() + ":";
    //} 
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        highScoreCounter = PlayerPrefs.GetInt("highScoreCounter", 0);
        scoreText.text = "Points " + scoreCounter.ToString() + ":";
        highScore.text = "Points " + highScoreCounter.ToString() + ":";
    }

    public void AddScore()
    {
        scoreCounter += 1;
        scoreText.text = "Points " + scoreCounter.ToString() + ":";
        if (highScoreCounter < scoreCounter)
        {
            PlayerPrefs.SetInt("highScoreCounter", scoreCounter);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
