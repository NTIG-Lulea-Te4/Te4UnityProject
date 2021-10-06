using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    int score ;

    // Start is called before the first frame update
        
    void Start()
    {
        score = 0;
        scoreText.text = "Points " + score.ToString() + ":";
    }

    private void Awake()
    {
        instance = this;
    }
    public void AddPoint()
    { 
            score += 1;
            scoreText.text = "Points " + score.ToString() + ":";
    }


    // Update is called once per frame
    void Update()
    {

    }
}
