using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel1BisStarter : MonoBehaviour
{
    public DoorController puertaQueQuedoAbierta;
    public Light luzQueQuedoVerde;
    public Color verde;

    void Start()
    {
        print("start: abro la puerta que quedo abierta");
        puertaQueQuedoAbierta.OpenDoor();
        TurnGreen();
    }

    public void TurnGreen()
    {
        print("turngreen: hago verde la luz que quedo verde");
        luzQueQuedoVerde.color = verde;

        //for (int i = 0; i < luces.Length; i++)
        //{
        //    luces[i].color = verde;
        //}
    }
}
