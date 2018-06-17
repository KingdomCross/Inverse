using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public float movement;
    public float timeMovement;
    private float maxTimeMovement;
    private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
        maxTimeMovement = timeMovement;
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        var velocity = new Vector2(movement, rb2d.velocity.y);
        rb2d.velocity = velocity;
        timeMovement -= Time.deltaTime;
        if (timeMovement <= 0)
        {
            movement = movement * -1;
            timeMovement = maxTimeMovement;
        }
    }
}
