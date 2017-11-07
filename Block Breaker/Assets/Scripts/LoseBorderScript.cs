using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseBorderScript : MonoBehaviour {

    LevelManager levelManager = new LevelManager();

	// Use this for initialization
	void Start () {
	    
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        print("Triggered");
        levelManager.LoadGame("Lose");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
