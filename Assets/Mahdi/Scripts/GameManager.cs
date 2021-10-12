using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public Text gameOverText;
    public GameObject restart;
    int score;

    bool gameOver = false;
    float restartDelay = 1f;
    public void GameOver()
    {
        if (gameOver == false)
        {
            gameOver = true;
            Debug.Log("tre");
            Invoke("Dead", restartDelay);

           // Invoke("Restart", restartDelay);

        }
    }
    public void Dead()
    {
        restart.SetActive(true);
        FindObjectOfType<RestartMenu>();
    }
}
