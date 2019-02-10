using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraControls : MonoBehaviour
{
    public Transform player;
    public float CamSmoothing = 0.125f;
    public Vector3 offset;
    public GameObject menu;
 

    private void Start()
    {
        menu.gameObject.SetActive(false);
    }
    private void Update()
      
    {
        if (Input.GetKey("escape"))
            Application.Quit();

            if (Input.GetKeyDown(KeyCode.M))
            
                menu.gameObject.SetActive(true);
        if (Input.GetKeyUp(KeyCode.M))

            menu.gameObject.SetActive(false);


        if (Input.GetKey(KeyCode.R))

            SceneManager.LoadScene(1);

    }

 
    private void FixedUpdate()
    {
        Vector3 CamPosition = player.position + offset;
        Vector3 SmoothCam = Vector3.Lerp(transform.position, CamPosition, CamSmoothing);
        transform.position = SmoothCam;
        transform.LookAt(player);

    }
}