using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondInfoContainer : MonoBehaviour
{


    int newScore;

    #region get/setters
    public int Score
    {
        get
        {
            return newScore;
        }
        set
        {
            newScore += value;
        }
    }
    #endregion

    public void Start()
    {
        newScore = InfoContainer.Score;

    }


}

