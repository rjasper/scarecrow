﻿using UnityEngine;
using System.Collections;

public class Stalking : MonoBehaviour {
    public GameObject player;
    public float speed = 1f;
    private Rigidbody2D rb;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// search and get near the position of player character
	void FixedUpdate () {
        Transform t = GetComponent<Transform>();
        Vector2 direction = player.transform.position - t.position;

        rb.velocity = speed * direction.normalized;
    }
}