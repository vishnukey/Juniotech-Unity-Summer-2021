using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Something Hit Me!");
        if (other.gameObject.CompareTag("Bean"))
        {
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Collider Activated!");
        if (other.gameObject.CompareTag("Bean"))
        {
            Destroy(gameObject);
        }
    }
}
