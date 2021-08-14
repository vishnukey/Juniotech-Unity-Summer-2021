using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update

    public float rotSpeed;
    public float bobSpeed;
    public float displacement;
    
    private Vector3 _starPosition;
    void Start()
    {
        _starPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime);
        transform.position = new Vector3(
            _starPosition.x,
            Mathf.Lerp(_starPosition.y - displacement, _starPosition.y + displacement,(Mathf.Sin(Time.time * bobSpeed) + 1)/2),
                _starPosition.z
            );
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        
        Destroy(gameObject);
    }
}
