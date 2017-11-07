using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizardScript : MonoBehaviour {

    int min;
    int max;
    int guess;
    int chances = 5;

    public Text compGuess;
    public Text wizChances;

    void StartGame()
    {
        // Initialize/Reset Variables
        min = 1;
        max = 1000;
        wizChances.text = "I have " + chances + " chances left!";
        NextGuess();
    }

    void NextGuess()
    {
        if (chances > 0)
        {
            System.Random rand = new System.Random();
            guess = rand.Next(min, (max + 1));

            compGuess.text = "Is it " + guess + "?";
            chances--;
            wizChances.text = "I have " + chances + " chances left!";
        }
        else {
            SceneManager.LoadScene("Win");
        }
    }

    void Start ()
    {
        StartGame();
	}

    public void GameHigher()
    {
        min = guess;
        NextGuess();
    }

    public void GameLower()
    {
        max = guess;
        NextGuess();
    }

    // Update is called once per frame
    void Update () {
        
    }
}
