using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel3SceneTester : MonoBehaviour
{
    public static Nivel3SceneTester instance;
    public PlayerMovement player;

    public Vector3 position1;
    public Vector3 position2;
    public Vector3 position3;
    public Vector3 position4;

    //public GameObject allPauseTexts;

    private void Awake()
    {
        if (instance) //esto es para que audiomanager sea unico. puse uno en cada escena, pero a traves de las escenas se mantiene vivo uno solo.
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    private void Start()
    {
        AudioManager.instance.StopByName("MainMenuMusic");
    }

    // Update is called once per frame
    void Update()
    {
        //if(PlayerStats.instance.isPaused)
        //{
        //    if (Input.GetKeyDown(KeyCode.Return))
        //    {
        //        Application.Quit();
        //    }
        //}

        if (Input.GetKeyDown(KeyCode.H))
        {
            player.controller.enabled = false;
            player.transform.position = position1;
            player.controller.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            player.controller.enabled = false;
            player.transform.position = position2;
            player.controller.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            player.controller.enabled = false;
            player.transform.position = position3;
            player.controller.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            player.controller.enabled = false;
            player.transform.position = position4;
            player.controller.enabled = true;
        }
    }

    public void KillAndRespawnPlayer()
    {
        player.controller.enabled = false;
        player.transform.position = position1;
        player.controller.enabled = true;
    }
}
