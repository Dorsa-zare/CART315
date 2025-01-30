using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player2 : MonoBehaviour
{
    public float racketSpeed;
    
    private Rigidbody2D rb;
    private Vector2 racketDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical2");
        racketDirection = new Vector2(0, directionY).normalized ;
    }
    
    // Called once per physics frame (Rigidbody)
    private void FixedUpdate()
    {
        rb.linearVelocity = racketDirection * racketSpeed;
    }
}
