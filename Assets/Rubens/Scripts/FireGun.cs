using UnityEngine;

public class FireGun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;

    //public GameObject bomb;
    //public Transform shotPoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {

            Debug.Log("hi");
            //GameObject CreateBomb = Instantiate(bomb, shotPoint.position, shotPoint.rotation);
            //CreateBomb.GetComponent<Rigidbody>().velocity = shotPoint.transform.up * damage;
        }
    }
}
