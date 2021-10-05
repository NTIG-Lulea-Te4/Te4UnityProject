using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rigidBody;
    public Quaternion quaternion;
    public float speed = 1;
    public int thisIsMySpecialValue = 2;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = this.gameObject.GetComponent<Rigidbody>();
        quaternion = new Quaternion();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidBody.AddForce(new Vector3(1, 0, 0));

            Debug.Log("Left");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidBody.AddForce(new Vector3(-1, 0, 0));

            Debug.Log("Left");
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {

            rigidBody.AddForce(new Vector3(0, 0, -1));

            Debug.Log("Left");
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidBody.AddForce(new Vector3(0, 0, 1));


            Debug.Log("Left");
        }

        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Physics.Raycast(ray, out hit);
            rigidBody.AddForce(hit.point.normalized, ForceMode.Acceleration);


            //rigidBody.MovePosition(transform.position + newPosition);
            //quaternion.SetFromToRotation(transform.position, hit.transform.position);
            //transform.rotation = quaternion ;
            //transform.position = Vector3.Lerp(transform.position, hit.transform.position, speed * Time.deltaTime);
            //Vector3 newPosition = new Vector3(hit.point , -hit.transform.position.y + transform.position.y, -hit.transform.position.z + transform.position.z).normalized;


            Debug.Log("This hit at " + hit.point);


        }
    }

}
