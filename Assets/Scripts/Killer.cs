﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour
{

    Transform transform;
    Vector3 orginalPos;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {

        transform = GetComponent<Transform>();
        orginalPos = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
       void Update()
    {
        if (transform.position[1] < -20)
        {
            transform.position = orginalPos;
            rb.velocity = new Vector2(0,0);
            //Destroy(gameObject);
        }

    }

    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("lol");
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("lol");
    }
}
