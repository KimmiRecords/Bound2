using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterPickup : Collectables
{
    public override void Interact()
    {
        PlayerStats.instance.SpeedBoosts++;
        print("agarraste un speedboost. tenes " + PlayerStats.instance.SpeedBoosts);
        base.Interact(); //el base es solo reproducir un sfx
    }
}
