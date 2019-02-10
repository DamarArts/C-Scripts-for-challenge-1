using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variant: MonoBehaviour
{
    Vector3 rotate1 = new Vector3(0, 360, 0);
    Vector3 rotate2 = new Vector3(0, -360, 0);

    Vector3 pointA = new Vector3(-1f, 1.5f, 36f);
    Vector3 pointB = new Vector3(-16.5f, 1.5f, 36f);
    void Update()
    {
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));

        transform.Rotate(Vector3.Lerp(rotate1, rotate2, Mathf.PingPong(Time.time, 1)));


    }

}

