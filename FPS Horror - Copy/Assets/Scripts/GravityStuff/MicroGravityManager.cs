using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicroGravityManager : MonoBehaviour
{
    public MicroGravityTrigger[] allMicroGravs;
    public MicroGravityGenerator mgGenerator;

    //Light[] todasLasLucesDelNivel;

    void Start()
    {
        mgGenerator.TurnOnGenerator += TurnOnMicroGravity;
        mgGenerator.TurnOffGenerator += TurnOffMicroGravity;


        //todasLasLucesDelNivel = FindObjectsOfType<Light>();
    }

    public void TurnOnMicroGravity()
    {
        for (int i = 0; i < allMicroGravs.Length; i++)
        {
            allMicroGravs[i].gameObject.SetActive(true);
        }

        //for (int i = 0; i < todasLasLucesDelNivel.Length; i++)
        //{
        //    todasLasLucesDelNivel[i].intensity *= 0.25f;
        //}
    }


    public void TurnOffMicroGravity()
    {
        for (int i = 0; i < allMicroGravs.Length; i++)
        {
            allMicroGravs[i].gameObject.SetActive(false);
        }

        //for (int i = 0; i < todasLasLucesDelNivel.Length; i++)
        //{
        //    todasLasLucesDelNivel[i].intensity *= 4f;
        //}
    }
}
