using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR;
using Eyes = UnityEngine.InputSystem.XR.Eyes;

public class Player : MonoBehaviour
{
    public Transform eyes;
    public float lookDistance = 10f;
    public LayerMask lookMask;

    public int maxHealth;
    private float _health;
    public TextMeshProUGUI healText;
    
    // Start is called before the first frame update
    void Start()
    {
        _health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        DoLook();
        healText.text = "Health: " + _health;
        if (_health <= 0)
        {
            Die();
        }
    }

    public void TakeDamage(float damageAmount)
    {
        _health -= damageAmount;
    }

    void Die()
    {
        // code for dying goes in here
        Destroy(gameObject);
    }

    private void DoLook()
    {
        RaycastHit hitinfo;
        if (Physics.Raycast(eyes.position, eyes.forward, out hitinfo, lookDistance, lookMask))
        {
            Debug.DrawRay(eyes.position, eyes.forward * lookDistance, Color.green);
            Responder res = hitinfo.transform.gameObject.GetComponent<Responder>();
            if (res != null)
            {
                res.ChangeColor();
            }
        }
        else
        {
            Debug.DrawRay(eyes.position, eyes.forward * lookDistance, Color.red);
        }
    }
}
