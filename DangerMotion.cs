﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerMotion : MonoBehaviour
    
{


    Vector3 pointA = new Vector3( 1f, 1.5f, 36f);
    Vector3 pointB = new Vector3(16.5f, 1.5f, 36f);

    void Update()
    {
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));

    }

}

