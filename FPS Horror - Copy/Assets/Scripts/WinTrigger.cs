using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTrigger : MonoBehaviour
{
    public CutscenePreloader cutscenePreloader;
    private void OnTriggerEnter(Collider other)
    {
        cutscenePreloader.asyncLoad.allowSceneActivation = true;
        //SceneManager.LoadScene("FinalCutscene");   
    }
}
