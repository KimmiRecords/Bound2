using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu2 : MonoBehaviour
{
    public string sceneName;

    void Start()
    {
        AudioManager.instance.StopAll();
        AudioManager.instance.PlayByName("MainMenuMusic");
    }

    void Update()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene(sceneName);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
