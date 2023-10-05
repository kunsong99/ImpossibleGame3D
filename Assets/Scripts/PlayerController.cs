using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.04f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>();
        //rigidBody.AddForce(0,10f,0);
        transform.Translate(0,0,speed);
    }
}
