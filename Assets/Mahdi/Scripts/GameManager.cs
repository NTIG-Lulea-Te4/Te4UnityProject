using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public Text gameOverText;
    bool gameOver = false;
    float restartDelay = 1f;
    public void GameOver()
    {
        if (gameOver == false)
        {
            gameOver = true;
            Debug.Log("GameOver");
            FindObjectOfType<GameOverScript>().SetUp(0);
            Invoke("Restart", restartDelay);

        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
