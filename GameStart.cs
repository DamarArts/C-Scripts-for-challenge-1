using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public Transform player;
    public float CamSmoothing = 0.125f;
    public Vector3 offset;
    public GameObject menu;
    private void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();

        if (Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.KeypadEnter))
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