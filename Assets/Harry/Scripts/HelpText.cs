using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpText : MonoBehaviour
{

    public GameObject helpText;
     
    // Start is called before the first frame update
    void Start()
    {
        helpText.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.H))
        {
            
            helpText.SetActive(true);

        }
        else
        {
            helpText.SetActive(false);
        }
        
 
    }

   
}
