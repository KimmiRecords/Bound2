using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicroGravityGenerator : Interactable
{
    public delegate void MyDelegate();
    public event MyDelegate TurnOnGenerator;

    public override void Interact()
    {
        base.Interact();
        TurnOnGenerator();
        //GeneratorFX();
    }

    public void GeneratorFX()
    {
        //particulas.gameobject.SetActive(true);
        //attachedSound.gameobject.SetActive(true);
    }
}
