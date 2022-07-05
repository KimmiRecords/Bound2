using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CutscenePreloader : MonoBehaviour
{
    public string cutsceneName;
    public FinalUSB finalUsb;
    public Image black;

    [HideInInspector]
    public AsyncOperation asyncLoad;

    private void Start()
    {
        if (finalUsb != null)
        {
            //finalUsb.OnFinalUSBPickup += StartPreload;
            finalUsb.OnFinalUSBPickup += StartBancalaCapo;

        }
    }

    //public void StartPreload()
    //{
    //    //StartCoroutine("PreloadScene");
    //    black.color = new Color(0, 0, 0, 1);

    //    asyncLoad = SceneManager.LoadSceneAsync(cutsceneName, LoadSceneMode.Single);
    //    print("arranque el loadSceneAsync de " + cutsceneName);
    //    asyncLoad.allowSceneActivation = false;

    //    black.color = new Color(0, 0, 0, 0);
    //}

    public void StartBancalaCapo()
    {
        StartCoroutine("BancalaCapo");
    }

    IEnumerator BancalaCapo()
    {
        black.color = new Color(0, 0, 0, 1);
        AudioManager.instance.PlayDerrumbe();


        yield return new WaitForSeconds(0.25f);

        asyncLoad = SceneManager.LoadSceneAsync(cutsceneName, LoadSceneMode.Single);
        print("arranque el loadSceneAsync de " + cutsceneName);
        asyncLoad.allowSceneActivation = false;

        yield return new WaitForSeconds(0.25f);

        black.color = new Color(0, 0, 0, 0);


    }
}
