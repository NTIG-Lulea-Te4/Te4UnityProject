using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullets : MonoBehaviour
{
    public int bulletstimmer = 20;
    public List<Vector3> bullets;

    void Update()
    {
        bulletstimmer--;
        if (bulletstimmer <=0)
        {
            bulletstimmer = 60;
            bullets.Add(new Vector3(20, 30, 20));
        }
        for (int i = 0; i < bullets.Count; i++)
        {
            bullets[i] = bullets[i] + new Vector3(10, 0, 0);
        }
    }



}
