﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeball : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
    }
}
