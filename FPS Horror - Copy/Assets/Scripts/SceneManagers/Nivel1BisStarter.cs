using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel1BisStarter : MonoBehaviour
{
    public DoorController puertaQueQuedoAbierta;
    public Light luzQueQuedoVerde;
    public Color verde;
    public FinalUSB finalUsb;


    void Start()
    {
        puertaQueQuedoAbierta.OpenDoor();
        TurnGreen();

        finalUsb.OnFinalUSBPickup += AudioManager.instance.TurnOnFinalAlarm; //suscribo el metodo PrenderAlarmas al evento
    }

    public void TurnGreen()
    {
        luzQueQuedoVerde.color = verde;

        //for (int i = 0; i < luces.Length; i++)
        //{
        //    luces[i].color = verde;
        //}
    }
}
