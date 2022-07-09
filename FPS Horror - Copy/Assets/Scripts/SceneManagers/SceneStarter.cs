using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneStarter : MonoBehaviour
{
    //este script carga los stats al inicio de la escena para preservar continuidad
    //por diego katabian

    public string conQueTemaArranco;

    void Start()
    {
        StatsManager.instance.LoadStats();

        AudioManager.instance.StopAll();
        AudioManager.instance.PlayByName(conQueTemaArranco);


        if (PlayerStats.instance.UsbsCollected > 0)
        {
            CanvasManager.instance.TurnOnCanvas("CanvasUSB");
        }

        if (PlayerStats.instance.hasFlashlight == true)
        {
            CanvasManager.instance.TurnOnCanvas("CanvasVidaUtil");
        }

        if (PlayerStats.instance.SpeedBoosts > 0)
        {
            CanvasManager.instance.TurnOnCanvas("CanvasJeringas");
        }
    }
}
