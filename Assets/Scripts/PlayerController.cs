using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    
    private CharacterController _controller;
    private bool grounded = false;
    
    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKey("w"))
        // {
        //     _controller.SimpleMove(transform.forward * speed);
        // }
        // if (Input.GetKey("s"))
        // {
        //     _controller.SimpleMove(-transform.forward * speed);
        // }
        // if (Input.GetKey("d"))
        // {
        //     _controller.SimpleMove(transform.right * speed);
        // }
        // if (Input.GetKey("a"))
        // {
        //     _controller.SimpleMove(-transform.right * speed);
        // }

        transform.Rotate(0, Input.GetAxis("Horizontal") * speed, 0);
        _controller.SimpleMove(transform.forward * Input.GetAxis("Vertical") * speed);

        grounded = _controller.isGrounded;
        
        // if (Input.GetKeyDown(KeyCode.Space) && _controller.isGrounded)
        // {
        //     _controller.Move(Vector3.up * 3 * speed);
        // }

        // if (Input.GetKey("e"))
        // {
        //     transform.Rotate(0, 1, 0);
        // }
        //
        // if (Input.GetKey("q"))
        // {
        //     transform.Rotate(0, -1, 0);
        // }
    }
}
