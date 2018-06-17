using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("OnStart");
        
	}
	
	// Update is called once per frame
	void Update () {
        
		
	}
    void OnTriggerEnter2D(Collider2D trigger2D)
    {
        Debug.Log("Hiro");
        if(trigger2D.gameObject.tag == "Hiro'schioce")
        {
            Debug.Log("Key");
        }
        if(trigger2D.gameObject.tag == "WrongMove")
        {
            Debug.Log("Monsters");

        }




    }

}
