﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float axisX, speed, jumpForce;
    private Rigidbody2D rbody;
    private SpriteRenderer spriteRender;
    public int facingDirection;
    public bool grounded;

    void Start ()
    {
        speed = 10;
        jumpForce = 200;
        rbody = GetComponent<Rigidbody2D>();
        spriteRender = this.GetComponent<SpriteRenderer>();

        if (this.transform.position.x <= 0) { this.facingDirection = 1; }
        else { facingDirection = -1; spriteRender.flipX = true; }
    }

	void FixedUpdate ()
    {
        axisX = Input.GetAxis("Horizontal");
        rbody.velocity = new Vector2(axisX * speed, transform.position.y);
        if(Input.GetKeyDown("w") && grounded)
        {
            rbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        if (axisX > 0) { this.facingDirection = 1; spriteRender.flipX = false; }
        else if (axisX < 0) { this.facingDirection = -1; spriteRender.flipX = true; }
    }

    void Update ()
    {
    
    }
}
