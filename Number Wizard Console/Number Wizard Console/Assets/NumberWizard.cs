using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to the Number Wizard Console Edition");
        Debug.Log("Please pick a number, don't say what it is");
        Debug.Log("The highest number you can choose is: " + max);
        Debug.Log("The lowest number you can choose is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push up if its higher, push down if its lower, Push Enter if its Correct");
        max ++;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Number is higher");
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Number is lower");
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Suck on that the computer guessed it!!!");
            Debug.Log("Starting Game Again");
            StartGame();
        }
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Guess is " + guess);
    }
}
