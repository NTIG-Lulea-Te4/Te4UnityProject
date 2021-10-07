using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    public Text highscoreText;

    private int score;
    private int highscore;


    public ScoreManager()
    {
        score = 0;
        highscore = 0;
    }

    public void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        // write the values as 0 by refering to my variables
        //`PlayerPrefs` is a class that stores Player preferences between game sessions.
        //It can store string, float and integer values into the user’s platform registry.
        highscore = PlayerPrefs.GetInt("highscore", 0); 
        scoreText.text = score.ToString() + " POINTS";
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " POINTS";
        if(highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }
}
