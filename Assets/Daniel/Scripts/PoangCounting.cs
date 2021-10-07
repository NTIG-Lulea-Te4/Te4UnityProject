using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoangCounting : MonoBehaviour
{
    public static Text poangText;
    public static int score = 0;

    // Start is called before the first frame update
     void Start()
    {
        poangText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        poangText.text = "Your Score: " + score;
    }



}
