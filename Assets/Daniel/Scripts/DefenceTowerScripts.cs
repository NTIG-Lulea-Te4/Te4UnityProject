//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class DefenceTowerScripts : MonoBehaviour
//{
//    private Vector3 shootPosition;
//    private void Awake()
//    {
//        shootPosition = transform.Find("ShootPosition").position;
//    }
//    // Start is called before the first frame update
//    void Start()
//    {

//    }
//    private static Vector3 GetMousePosition()
//    {
//        Vector3 vector = GetMousePositionWithZ(Input.mousePosition, Camera.main);
//        vector.z = 0f;
//        return vector;
//    }
//    private static Vector3 GetMousePositionWithZ()
//    {
//        return GetMousePositionWithZ(Input.mousePosition, Camera.main);
//    }
//    private static Vector3 GetMousePositionWithZ(Camera worldCamera)
//    {
//        return GetMousePositionWithZ(Input.mousePosition, worldCamera);
//    }
//    private static Vector3 GetMousePositionWithZ(Vector3 screenPosition, Camera worldCamera)
//    {
//        Vector3 worldPosition = worldCamera.ScreenToWorldPoint(screenPosition);
//        return worldPosition;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (Input.GetMouseButton(0))
//        {
//            BulletsControl bullet = new BulletsControl();
//            bullet.CreateBullets(GetMousePosition());
//        }

//    }
//}
