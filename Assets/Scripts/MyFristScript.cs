using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFristScript : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    
    private Rigidbody body;
    
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel = Vector3.zero;
        
        if (Input.GetKey("w"))
        {
            //transform.position += speed * transform.forward * Time.deltaTime;
            //body.velocity = speed * transform.forward;
            vel += transform.forward;
        }
        if (Input.GetKey("s"))
        {
            //transform.position += speed * transform.forward * Time.deltaTime;
            //body.velocity = speed * transform.forward;
            vel += -transform.forward;
        }
        if (Input.GetKey("d"))
        {
            //transform.position += speed * transform.forward * Time.deltaTime;
            //body.velocity = speed * transform.forward;
            vel += transform.right;
        }
        if (Input.GetKey("a"))
        {
            //transform.position += speed * transform.forward * Time.deltaTime;
            //body.velocity = speed * transform.forward;
            vel += -transform.right;
        }

        body.velocity = vel * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(jumpForce * transform.up);
        }
    }
}
