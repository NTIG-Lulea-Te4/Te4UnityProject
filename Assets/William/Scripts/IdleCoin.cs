using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleCoin : MonoBehaviour
{

    public float spinSpeed;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(new Vector3(0, spinSpeed, 0) * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {

        Destroy(this.gameObject);
    }

}
