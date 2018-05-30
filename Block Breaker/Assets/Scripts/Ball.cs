﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public Paddle paddle;

	private Vector3 paddleToBallVector;
	private bool gameStarted = false;
	// Use this for initialization
	void Start () {
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		if (!gameStarted) 
			// Lock ball relative to the paddle
			this.transform.position = paddle.transform.position + paddleToBallVector;

		// wait for mouse click before starting the game
		if (Input.GetMouseButtonDown(0)) {
			gameStarted = true;

			this.GetComponent<Rigidbody2D>().velocity = new Vector2(3f, 10f);
		}
	}
}