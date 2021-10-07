using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoContainer : MonoBehaviour
{


    static int score;

    #region get/setters
    static public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
        }
    }


    #endregion


}
