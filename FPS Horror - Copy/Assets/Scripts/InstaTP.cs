using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstaTP : MonoBehaviour
{
    // cuando tocas el objeto con este script, te insta-tpea

    //si spawneaTexto es true, va a activar dicho gameobject

    public Vector3 destination;

    public bool activaGameObject;
    public GameObject gameObjectDeseado;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>() != null)
        {
            var otro = other.GetComponent<PlayerMovement>();
            otro.TPToCheckpoint(destination);

            if (activaGameObject)
            {
                gameObjectDeseado.SetActive(true);
            }
        }
    }
}
