using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnCollision : MonoBehaviour
{
    public GameObject gameOver;
    private void OnCollisionEnter(Collision collision) // normal collison between two objects
    {
        if (collision.collider.CompareTag("Point Box")) // collider = the collider we hit
        {
            //Debug.Log("Collided");
            ScoreManager.instance.AddPoint();
            Destroy(collision.gameObject);
            FindObjectOfType<GameOverScreen>().Setup();
            gameOver.SetActive(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
