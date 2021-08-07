using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class DeathField : MonoBehaviour
{
    public GameObject text;
    public Transform spawnPoint;
    public Transform player;

    public float maxHeight;
    public float totalTime;

    private Vector3 _startPosition;
    private float _elapsedTime;

    private void Start()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(
            _startPosition, 
            _startPosition + maxHeight * transform.up,
            _elapsedTime / totalTime
            );
        _elapsedTime += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }

        //Time.timeScale = 0;
        text.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Respawn()
    {
        Debug.Log("respawn button clicked");
        text.SetActive(false);
        player.position = spawnPoint.position;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        _elapsedTime = 0;
        //Time.timeScale = 1;
    }
}
