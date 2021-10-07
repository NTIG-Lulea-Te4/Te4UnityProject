using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float rotationSpeed = 10;
    //Vector3 currentEulerAngels;
    public Vector3 rotation;
    //public Vector3 point;
    public GameObject target;
    //public GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(-1, 0, 0), 20 * Time.deltaTime);
            //GetComponent<Transform>().eulerAngles = new Vector3(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(1, 0, 0), 20 * Time.deltaTime);
            //GetComponent<Transform>().eulerAngles = new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, 0, -1), 20 * Time.deltaTime);
            //GetComponent<Transform>().eulerAngles = new Vector3(-1, 1, -1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 0, 1), 20 * Time.deltaTime);
            //GetComponent<Transform>().eulerAngles = new Vector3(-1, 1, -1);
        }



        /* void OnCollisionEnter(Collision collison)
         {
             Destroy(collison.collider.gameObject);
             Destroy(gameObject);
         }

         /*  void OnCollisionEnter(Collision collision)
           {
               if (Collision.tag == "target")
               {

               }



       }
        void OncollisionEnter(Collision YourGameobjectasAVarable)
        {
            if(YourGameobjectasAVarable.collider.tag == "target")
            {
                Destroy(target);
            }
        }
        */
    }
}