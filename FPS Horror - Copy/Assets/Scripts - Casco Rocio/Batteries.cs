using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batteries : MonoBehaviour
{
    public Slots slot;
    public BatteryPickup batteryPickup;
    public FlashlightLife flashlightLife;
    public int batteryRecharge;

    public void UseBatteries()
    {
        if (slot.id == 1)
        {
            flashlightLife.timer += batteryRecharge;
            Debug.Log("active las baterias");
            slot.id = 0;

        }

    }
}
