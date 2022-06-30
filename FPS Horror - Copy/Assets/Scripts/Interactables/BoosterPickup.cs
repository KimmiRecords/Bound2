using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterPickup : Collectables
{
    public override void Interact()
    {
        PlayerStats.instance.SpeedBoosts++;
        AudioManager.instance.PlayPickup(1.1f);
        print("agarraste un speedboost. tenes " + PlayerStats.instance.SpeedBoosts);
        //base.Interact(); //el base es solo reproducir un sfx

        //GameObject itemPickedUp = this.gameObject; //que objeto agarre
        //Items item = itemPickedUp.GetComponent<Items>(); //su componente item
        //inventory.AddItem(itemPickedUp, item.id, item.type, item.icon); //lo agrego. 
    }
}
