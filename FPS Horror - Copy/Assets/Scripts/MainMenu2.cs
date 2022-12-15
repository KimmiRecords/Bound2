using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu2 : MonoBehaviour
{
    public string[] sceneNames;

    void Start()
    {
        AudioManager.instance.StopAll();
        AudioManager.instance.PlayByName("MainMenuMusic");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(sceneNames[0]);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene(sceneNames[1]);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
