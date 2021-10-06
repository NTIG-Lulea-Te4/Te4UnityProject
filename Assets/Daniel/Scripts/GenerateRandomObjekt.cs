//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class GenerateRandomObjekt : MonoBehaviour
//{
//    public GameObject sample;
//    public int xPosition;
//    public int zPosition;
//    public int ObjectQuantity;
//    // Start is called before the first frame update
//    void Start()
//    {
//        StartCoroutine(CreateObjects());
//    }

//    // Update is called once per frame
//    IEnumerator CreateObjects()
//    {
//        while (ObjectQuantity < 10)
//        {


//            xPosition = Random.Range(11, 25);
//            zPosition = Random.Range(-17, 7);
//            Instantiate(sample, new Vector3(xPosition, 20, zPosition), Quaternion.identity);
//            yield return new WaitForSeconds(0.1f);
//            ObjectQuantity++;
//        }
//    }
//}
