using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class SJump : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public bool isRight = true;
    public float distance = 0.3f;
    private Vector3 pointAPosition;
    private Vector3 pointBPosition;
    private Rigidbody2D rb;
    public Sprite groundSprite;
    public Sprite airSprite;
    // Use this for initialization
    void Start()
    {
        pointAPosition = new Vector3(pointA.position.x, 0, 0);
        pointBPosition = new Vector3(pointB.position.x, 0, 0);
        rb = GetComponent<Rigidbody2D>();
    }

    void fly(int i)
    {
        if (isRight)
        {
            Vector3 v = new Vector3(distance, distance, 0);
            rb.AddForce(v, ForceMode2D.Impulse);
            GetComponent<SpriteRenderer>().sprite = airSprite;
        }
        else
        {
            Vector3 v = new Vector3(-distance, distance, 0);
            rb.AddForce(v, ForceMode2D.Impulse);
            GetComponent<SpriteRenderer>().sprite = airSprite;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.x == 0)
        {
            GetComponent<SpriteRenderer>().sprite = groundSprite;
        }
        if (GetComponent<SpriteRenderer>().sprite == airSprite)
        {
            Vector3 thisPosition = new Vector3(transform.position.x, 0, 0);
            if (thisPosition.x < pointAPosition.x)
            {
                isRight = false;
                GetComponent<SpriteRenderer>().flipX = true;
            }
            if (thisPosition.x > pointBPosition.x)
            {
                isRight = true;
                GetComponent<SpriteRenderer>().flipX = false;
            }
        }
        if (GetComponent<SpriteRenderer>().sprite == groundSprite)
        {
            GetComponent<Animator>().Play("Base Layer.slime");
        }
    }
}