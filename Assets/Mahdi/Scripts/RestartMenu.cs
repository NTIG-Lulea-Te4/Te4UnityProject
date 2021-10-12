using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;
    int scoreCounter = 12;
    public void Restart()
    {
        highScoreText.text = "Points " + scoreCounter;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
