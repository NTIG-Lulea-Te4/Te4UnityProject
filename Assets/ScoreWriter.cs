using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreWriter : MonoBehaviour
{
 
    public TextMesh scoreWriter;
    
    // Start is called before the first frame update
    void Start()
    {
        
        scoreWriter.text = Convert.ToString(2);
        
    }

    // Update is called once per frame
    void Update()
    {
 
       scoreWriter.text = Convert.ToString(ValueHolder.coinCounter);
      
    }
}
