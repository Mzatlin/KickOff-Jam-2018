﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour {
    Rigidbody2D rb;

    public Animator animator;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveplayer();
    }
    void moveplayer()
    {
        rb.velocity = new Vector2(2*(PlayerManager.player.Speed * Time.deltaTime), 0);
    }


}

