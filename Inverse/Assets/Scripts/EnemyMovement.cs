using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public float movement;
    public float timeMovement;
    private float maxTimeMovement;

	// Use this for initialization
	void Start () {
        maxTimeMovement = timeMovement;

    }
	
	// Update is called once per frame
	void Update () {
        var x = Time.deltaTime * movement;
        transform.Translate(x, 0, 0);
        timeMovement -= Time.deltaTime;
        if (timeMovement <= 0)
        {
            movement = movement * -1;
            timeMovement = maxTimeMovement;
        }
    }
}
