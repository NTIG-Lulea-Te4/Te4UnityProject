using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHealth : MonoBehaviour
{
    public static BallHealth instance;

    //public GameOverScreen gameOverScreen;

    [SerializeField]
    HeartSystem heartSystem;

    public int hearts;
    public int maxHearts;

    [SerializeField]
    private int boomb;

    public BallHealth()
    {
        hearts = 3;
        maxHearts = 3;
    }

    public  void Awake()
    {
        instance = this;
    }

    //public void GameOver()
    //{
    //    if(hearts == 0)
    //    {
            
    //    }
    //}

    public void Start()
    {
        heartSystem.DrawHearts(hearts, maxHearts);
    }

    public void DamageBall()
    {
        if (hearts > 0)
        {
            hearts -= 1;
            heartSystem.DrawHearts(hearts, maxHearts);
        }
    }

    public void HealBall()
    {
        if (hearts < maxHearts)
        {
            hearts += 1;
            heartSystem.DrawHearts(hearts, maxHearts);
        }
    }
}