using UnityEngine;

public class FireGun : MonoBehaviour
{
    public Transform spawnpoint;
    public GameObject prefab;

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

        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 40;
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePos);

        Instantiate(prefab, worldPosition, Quaternion.identity);
    }
}
