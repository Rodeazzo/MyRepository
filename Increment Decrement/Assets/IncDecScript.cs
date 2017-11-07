using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncDecScript : MonoBehaviour {

    int num = 50;

	// Use this for initialization
	void Start () {
        print("Welcome to Number Increment/Decrement!");
        StartGame();
	}

    void StartGame()
    {
        print("Current value is: " + num);
        print("Press up arrow to increment");
        print("Press down arrow to decrement");
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Value Incremented!");
            num++;
            StartGame();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Value Decremented!");
            num--;
            StartGame();
        }
        else if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            print("Closing Game");
            print("Thank you for playing!");
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
