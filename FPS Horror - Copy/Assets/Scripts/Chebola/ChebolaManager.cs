using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChebolaManager : MonoBehaviour
{
    public static ChebolaManager instance;

    void Start()
    {
        if (instance)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    public void ReActivateChebola(GameObject chebola)
    {
        chebola.SetActive(true);
        print("reactive al chebola " + chebola.name);
    }
}
