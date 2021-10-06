using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform player;
    public Vector3 cameraPosition;

    void Update()
    {
        transform.position = player.position + cameraPosition;
    }
}
