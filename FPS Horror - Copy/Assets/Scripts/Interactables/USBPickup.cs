using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class USBPickup : Collectables
{
    //los usb pickup solo te suman 1 usb
    //por diego katabian

    public USBManager usbManager;

    public override void Interact()
    {
        if (PlayerStats.instance.UsbsCollected == 0)
        {
            CanvasManager.instance.TurnOnCanvas("CanvasUSB");
        }

        usbManager.AddUsb(this.gameObject);
        PlayerStats.instance.UsbsCollected++;
        base.Interact();
    }
}
