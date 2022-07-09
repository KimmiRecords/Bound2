using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    //con este script prendo y apago canvases
    //los ordene en un diccionario para poder disparar el metodo en otros script y no necesitar refe al go, sino solo saber el nombre. 
    //por diego katabian

    public static CanvasManager instance;

    public GameObject canvasUSB;
    public GameObject canvasBatteries;
    public GameObject canvasJeringas;
    public GameObject canvasVidaUtil;

    public Dictionary<string, GameObject> canvases = new Dictionary<string, GameObject>();

    void Start()
    {
        if (instance)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }

        canvases.Add("CanvasUSB", canvasUSB);
        canvases.Add("CanvasBatteries", canvasBatteries);
        canvases.Add("CanvasJeringas", canvasJeringas);
        canvases.Add("CanvasVidaUtil", canvasVidaUtil);

    }

    public void TurnOnCanvas(string canvasName)
    {
        canvases[canvasName].SetActive(true);
    }
}
