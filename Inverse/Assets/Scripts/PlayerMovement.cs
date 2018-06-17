using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float Speed;
    public float jumpSpeed;
    public Rigidbody2D Rb2d;

	// Use this for initialization
	void Start () {
        Rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        var xAxis = Input.GetAxis("Horizontal");
        var velocity = Rb2d.velocity;
        velocity.x = xAxis * Speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Down");
            velocity.y = jumpSpeed;
        }
        Rb2d.velocity = velocity;
    }
}
