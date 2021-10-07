using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    Rigidbody rigidbody;
    Vector3 vectorX;
    Vector3 vectorY;
    Vector2 playerPositionOnScreen;
    Vector2 mouseCursorPosistionOnScreen;

    float angle;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        vectorX = new Vector3(5, 0, 0);
        vectorY = new Vector3(0, 0, 5);

    }

    // Update is called once per frame
    void Update()
    {
        //Tar positionen på karatären och musen
        #region inverted
        playerPositionOnScreen = Camera.main.WorldToViewportPoint(transform.position);
        mouseCursorPosistionOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);
        #endregion

        angle = AngleBetweenTwoPoints(playerPositionOnScreen, mouseCursorPosistionOnScreen);

        transform.rotation = Quaternion.Euler(new Vector3(0, angle, 0));

        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddForce(vectorX * -1);

        }

        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.AddForce(vectorX);

        }

        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(vectorY * -1);

        }

        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(vectorY);

        }

    }
        //Läskig matte som räknar vinklar
        float AngleBetweenTwoPoints(Vector3 playerPosistion, Vector3 mousePosition)
        {
            return Mathf.Atan2(playerPosistion.y - mousePosition.y, playerPosistion.x - mousePosition.x) * Mathf.Rad2Deg;

        }


    
}
