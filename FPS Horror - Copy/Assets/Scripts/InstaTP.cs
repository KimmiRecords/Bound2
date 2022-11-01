using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstaTP : MonoBehaviour
{
    // cuando tocas el objeto con este script, te insta-tpea

    public Vector3 destination;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>() != null)
        {
            var otro = other.GetComponent<PlayerMovement>();
            otro.TPToCheckpoint(destination);
        }
    }
}
