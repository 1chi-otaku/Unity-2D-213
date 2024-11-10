using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D rb2d; 
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb2d.AddForce(Vector2.up * 5);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddForce(Vector2.left * 5);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddForce(Vector2.right * 5);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb2d.AddForce(Vector2.down * 5);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb2d.AddTorque(5);
        }
        if (Input.GetKey(KeyCode.F))
        {
            rb2d.angularVelocity = 0;
            rb2d.velocity.Set(0,0);
        }

    }
}
