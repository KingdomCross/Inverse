using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour {
    public int playerHeatlh;
    public float hurtCooldown;
    private float maxHurtCooldown;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (maxHurtCooldown > 0)
        {
            maxHurtCooldown -= Time.deltaTime;
        }
	}
    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag == "Enemy" && maxHurtCooldown <= 0)
        {
            playerHeatlh -= 1;
            Debug.Log(playerHeatlh);
            maxHurtCooldown = hurtCooldown;
        }
        if (playerHeatlh <= 0)
        {
            Destroy(gameObject);
        }
    }
}
