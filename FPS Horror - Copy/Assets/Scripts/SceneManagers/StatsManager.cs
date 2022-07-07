using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsManager : MonoBehaviour
{
    //la idea de este script es que perdura entre escenas y guarda toda la info necesaria, por ej. usbs recolectados
    //por diego katabian

    public static StatsManager instance;

    int usbsRecolectados;
    bool tengoLinterna;
    bool tengoCardKey;
    int jeringasRecolectadas;

    private void Start()
    {
        if (instance)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this);
    }

    public void SaveStats()
    {
        usbsRecolectados = PlayerStats.instance.UsbsCollected;
        tengoLinterna = PlayerStats.instance.hasFlashlight;
        tengoCardKey = PlayerStats.instance.hasCardKey;
        jeringasRecolectadas = PlayerStats.instance.SpeedBoosts;

        //print("statsmanager: guarde los siguientes stats:");
        //print("usbs: " + usbsRecolectados);
        //print("linterna: " + tengoLinterna);
        //print("cardkey: " + tengoCardKey);
        //print("jeringas: " + jeringasRecolectadas);
    }

    public void LoadStats()
    {
        PlayerStats.instance.UsbsCollected = usbsRecolectados;
        PlayerStats.instance.hasFlashlight = tengoLinterna;
        PlayerStats.instance.hasCardKey = tengoCardKey;
        PlayerStats.instance.SpeedBoosts = jeringasRecolectadas;

        //print("statsmanager: cargue los siguientes stats:");
        //print("usbs: " + PlayerStats.instance.UsbsCollected);
        //print("linterna: " + PlayerStats.instance.hasFlashlight);
        //print("cardkey: " + PlayerStats.instance.hasCardKey);
        //print("jeringas: " + PlayerStats.instance.SpeedBoosts);

        if (PlayerStats.instance.hasFlashlight)
        {
            Invoke("ActivarModeloLinterna", 0.1f);
        }

        if (PlayerStats.instance.hasCardKey)
        {
            //print("granted access xq tenes la cardkey");
            PlayerStats.instance.GrantAccess(PlayerStats.instance.cardKeyAccesses);
        }
    }

    void ActivarModeloLinterna()
    {
        PlayerStats.instance.CanvasVidaUtil.SetActive(true);
        PlayerStats.instance.ModeloLinterna.SetActive(true);
    }

}
