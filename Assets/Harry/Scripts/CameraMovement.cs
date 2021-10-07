using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private void LateUpdate()
    {
        Vector3 noAfterLag = target.position + offset;
        Vector3 afterLag = Vector3.Lerp(transform.position, noAfterLag, smoothSpeed);
        transform.position = afterLag;
    }
}
