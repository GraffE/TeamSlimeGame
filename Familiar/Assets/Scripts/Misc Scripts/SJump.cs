using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class SJump : MonoBehaviour
{
    public bool isRight = true;
    public float speed = 1.0f;
    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    // Update is called once per frame
    void Update()
    {
        if (isRight)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        } else
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
    }
}