using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureTextHitScript : MonoBehaviour
{

    Material material;
    public float duration = 60.0f;

    
    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<Renderer>().material;
        print("Materials " + Resources.FindObjectsOfTypeAll(typeof(Material)).Length);
        
    }

    // Update is called once per frame
    void Update()
    {


    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            
            material.color = Color.green;

        

        }



    }

    public void SetTexture(string textureName, Texture value)
    {

        //GetComponent<MeshRenderer>().material = ;

    }
}
