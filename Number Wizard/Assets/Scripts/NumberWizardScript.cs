using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizardScript : MonoBehaviour {
    int min;
    int max;
    int guess;

    // Methods (Functions in Python)
    void StartGame()
    {
        // Reset Variables
        min = 1;
        max = 1000;

        print("Welcome to Number Wizard!");
        print("Pick a number between 1 and 1000");

        NextGuess();
    }

    void NextGuess()
    {
        /* 
            This Method always generates a new guess and prints it in the console window
         */

        //guess = (min + max) / 2; // Guess is the middle value of the current range

        System.Random rand = new System.Random(); // Created the copy of the random class so that I can use its methods
        guess = rand.Next(min, (max + 1)); // Next is a method which generates a random value between the specified range

        print("Is the number higher, lower or equal to " + guess + "?");
        print("Higher: UP arrow, Lower: DOWN arrow, Equal: ENTER");
    }

    // Use this for initialization
    void Start () {
        //int randNum = Random.Range(min, max);
        StartGame();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up Arrow was pressed");
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down Arrow was pressed");
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            print("Enter Key was pressed");
            print("I won!");

            // Re-Start Game
            StartGame();
        }
	}
}
