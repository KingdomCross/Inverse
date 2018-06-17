using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float Speed;
    public float jumpSpeed;
    public Rigidbody2D Rb2d;
    private bool jumpBool = false;
    public AudioSource source;
    private float soundTime;
    public float footSoundPlayTime;

	// Use this for initialization
	void Start () {
        Rb2d = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        var xAxis = Input.GetAxis("Horizontal");
        var velocity = Rb2d.velocity;
        velocity.x = xAxis * Speed;

        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && jumpBool == true)
        {
            Debug.Log("Down");
            jumpBool = false;
            velocity.y = jumpSpeed;
        }
        Rb2d.velocity = velocity;
        soundTime += Time.deltaTime;
        if (soundTime >= footSoundPlayTime && (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)))
        {
            soundTime = 0;
            source.Play();
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        jumpBool = true;
    }
}
