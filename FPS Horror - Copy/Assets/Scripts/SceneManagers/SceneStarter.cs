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
    }
}
