using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayNum : MonoBehaviour {

    public Text myText;
    public InputField userInput;
    public Button userAns;

    int num1, num2, userGuess, totalSum;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    public void CheckAnswer()
    {
        userGuess = int.Parse(userInput.text);
        // userGuess = System.Convert.ToInt32(userInput.text); // Other way

        if (userGuess == totalSum)
        {
            print("Correct!");
            userInput.text = ""; // Clear user input field
            StartGame();
        }
        else {
            print("Incorrect!");
        };
    }

    void StartGame()
    {
        System.Random rand = new System.Random(); // Random class found in System Library
        // Random unityRand = new Random(); // Random class found in UnityEngine Library
        // num1 = Random.Range(1, 11); UnityEngine

        num1 = rand.Next(1, 11);
        num2 = rand.Next(1, 11);

        totalSum = num1 * num2;

        myText.text = ("Welcome to Multiplication Wizard!\n" +
                      "What is: " + num1 + " x " + num2 + " = ?");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
