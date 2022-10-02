using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel3SceneTester : MonoBehaviour
{
    public PlayerMovement player;

    public Vector3 position1;
    public Vector3 position2;
    public Vector3 position3;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            player.controller.enabled = false;
            player.transform.position = position1;
            player.controller.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            player.controller.enabled = false;
            player.transform.position = position2;
            player.controller.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            player.controller.enabled = false;
            player.transform.position = position3;
            player.controller.enabled = true;
        }
    }
}
