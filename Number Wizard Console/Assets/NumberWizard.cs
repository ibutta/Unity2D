using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private uint maxNum;
    private uint minNum;
    private uint guess;
    private uint attempts;
    private bool isGameRunning;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        
        //switch(Input.)
    }

    void OnGUI()
    {
        if (Event.current.isKey && 
            Event.current.type.Equals(EventType.KeyDown))
        {
            switch (Event.current.keyCode)
            {
                case KeyCode.UpArrow:
                    if (isGameRunning)
                    {
                        minNum = guess;
                        NextGuess();
                        Debug.Log("Higher than " + minNum + "?!\n" +
                            "So how about " + guess + "? Is this your number?!");
                    }
                    break;
                case KeyCode.DownArrow:
                    if (isGameRunning)
                    {
                        maxNum = guess;
                        NextGuess();
                        Debug.Log("Lower than " + maxNum + "?!\n" +
                            "So how about " + guess + "? Is this your number?!");
                    }
                    break;
                case KeyCode.Return:
                    if (isGameRunning)
                    {
                        isGameRunning = false;
                        if (attempts == 1)
                        {
                            Debug.Log("Haha! Bullseye!!!");
                        }
                        else
                        {
                            Debug.Log("Finally, after " + attempts + " attempts, I got it right!");
                        }
                        Debug.Log("Hey, do you wanna play again?! `\nY = Yes || N = No");
                    }
                    break;
                case KeyCode.Y:
                    if (!isGameRunning)
                    {
                        StartGame();
                    }
                    break;
            }
        }
    }

    void StartGame()
    {
        maxNum = 501;
        minNum = 1;
        attempts = 0;
        isGameRunning = true;
        NextGuess();
        Debug.Log("Welcome to Number Wizard...\n" +
            "Please, pick a number between " + (maxNum - 1) + " and " + minNum + ".");
        Debug.Log("Now tell me, is " + guess + " the number you've chosen?!\n" +
            "Up Arrow (^) = Higher || Down Arrow (v) = Lower || Enter = Correct!");

    }

    private void NextGuess()
    {
        guess = ((maxNum + minNum) / 2);
        ++attempts;
    }

}
