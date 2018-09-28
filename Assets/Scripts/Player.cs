using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // Designer variables
    public float speed = 10;

    public Rigidbody2D physicsBody; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Get axis input from Unity
        float leftRight = Input.GetAxis("Horizontal");
        float upDown = Input.GetAxis("Vertical");

        // Create direction vector from axis input
        Vector2 direction = new Vector2(leftRight, upDown);

        // Make direction vector length 1
        direction = direction.normalized;

        // Calculate velocity
        Vector2 velocity = direction * speed;

        // Give the velocity to the rigidbody
        physicsBody.velocity = velocity;
	}
}
