using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePrinter : MonoBehaviour
{

    public TextMesh scoreWriter;

    void Update()
    {
        scoreWriter.text = Convert.ToString(InfoContainer.Score);


    }
}
