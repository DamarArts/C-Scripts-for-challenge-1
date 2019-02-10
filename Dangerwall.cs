using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dangerwall : MonoBehaviour
{
        private Rigidbody dw;
        Collider dw_Collider;

        public GameObject rb;


    void Start()
    {
        dw_Collider = GetComponent<Collider>();
        rb = GetComponent<GameObject>();

    }

void Update()
    {
         dw_Collider.enabled = !dw_Collider.enabled;
    }

    private void OnCollisionStay(Collision rb)
    {
        dw_Collider.enabled = !dw_Collider.enabled;
    }
}
