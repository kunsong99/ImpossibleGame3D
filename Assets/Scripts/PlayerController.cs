using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.04f;
    public float defaultVelocityY = 100.0f;
    public float defaultJumpForceY = 300.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>();
        float velocityY = rigidBody.velocity.y;
        
        if (velocityY < -0.1f)
        {
            velocityY = defaultVelocityY;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,speed);
        //these two ways both work
        //if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        if(Input.GetButtonDown("Jump"))
        {
            Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>();
            rigidBody.AddForce(0,defaultJumpForceY,0);
        }
    }
}
