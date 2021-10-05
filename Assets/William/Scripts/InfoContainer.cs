using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoContainer : MonoBehaviour
{

    int score = 0;
        
    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score += value;
        }
    }

}
