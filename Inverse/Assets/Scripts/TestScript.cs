using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

    public GameObject keyObject;
    public GameObject[] monsterObjects;
    public bool isKeySwitch;
	// Use this for initialization
	void Start () {
        Debug.Log("OnStart");
        
	}
	
	// Update is called once per frame
	void Update () {
        
		
	}
    void OnTriggerStay2D(Collider2D trigger2D)
    {
        Debug.Log("Hiro");
        if(trigger2D.tag == "Player")
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                if (isKeySwitch)
                    Instantiate(keyObject, transform.position, Quaternion.identity);
                else
                {
                    foreach (GameObject monster in monsterObjects)
                       Instantiate(monster, transform.position, Quaternion.identity);
                }
            }
        }
        /*if(trigger2D.gameObject.tag == "Hiro'schioce")
        {
            Debug.Log("Key"); 
            if(Input.GetKeyDown(KeyCode.E))
            {
                Instantiate(keyObject, transform.position, Quaternion.identity);
            }

        }
        if(trigger2D.gameObject.tag == "WrongMove")
        {
            Debug.Log("Monsters");
            if (Input.GetKeyDown(KeyCode.E))
            {
                foreach(GameObject monster in monsterObjects)
                {
                    Instantiate(monster, transform.position, Quaternion.identity);
                }

            }
        
        }*/




    }

}
