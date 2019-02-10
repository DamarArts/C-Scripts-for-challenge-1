using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variant: MonoBehaviour
{
    Vector3 rotate1 = new Vector3(0, 360, 0);
    Vector3 rotate2 = new Vector3(0, -360, 0);


    void Update()
    {
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
    }

}

