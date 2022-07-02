using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomerSounds
{
    Patrol boomer;
    public BoomerSounds(Patrol p)
    {
        boomer = p;
    }

    public void UpdateSoundsPosition()
    {
        AudioManager.instance.sound["ZombieIdleSFX"].transform.position = boomer.transform.position;
        AudioManager.instance.sound["ZombieRun"].transform.position = boomer.transform.position;
        AudioManager.instance.sound["ZombiePainScream"].transform.position = boomer.transform.position;
    }
}
