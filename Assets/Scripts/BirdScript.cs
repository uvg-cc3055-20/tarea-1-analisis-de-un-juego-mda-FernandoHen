﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {

    public float jumpForce = 500f;
    private Rigidbody2D rb;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        if (Input.GetButtonDown("Jump")) {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumpForce);

            
        }
	}
    private void OneTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("test");


        GameController.instance.score++;
        Debug.Log(GameController.instance.score);


    }

}
