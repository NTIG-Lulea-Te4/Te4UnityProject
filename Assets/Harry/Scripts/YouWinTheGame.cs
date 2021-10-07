using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWinTheGame : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Goal"))
        {
            Debug.Log("You win");
            Destroy(gameObject);
            SceneManager.LoadScene("NumberTwo", LoadSceneMode.Single);
        }
        if (other.transform.CompareTag("DangerHole"))
        {
            Debug.Log("You Lose");
            Destroy(gameObject);
        }

    }
    
}
