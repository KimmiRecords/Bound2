using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadePickup : Collectables
{
    public override void Interact()
    {
        base.Interact();
        PlayerStats.instance.Grenades++;
        print("agarre una granada");
    }
}
