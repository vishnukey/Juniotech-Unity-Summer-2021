using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoThing : MonoBehaviour
{

    public Transform spawnLocation;
    public GameObject spawnObject;
    public Responder responder;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(spawnObject, spawnLocation);
            responder.ChangeColor();
            Destroy(gameObject);
        }
    }
}
