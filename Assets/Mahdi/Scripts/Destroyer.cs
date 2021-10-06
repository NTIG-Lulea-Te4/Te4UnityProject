using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameObject gameObjectToBeDestroyed;

    float timeBeforeBeGone = 15f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObjectToBeDestroyed, timeBeforeBeGone);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
