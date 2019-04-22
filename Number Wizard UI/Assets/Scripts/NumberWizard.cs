using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField]
    int maxNum, minNum;
    int guess, oldGuess;
    [SerializeField]
    TextMeshProUGUI guessText;
    [SerializeField]
    Button higherBtn, lowerBtn;
    int attempts;

    private void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
        //++maxNum;
    }

    private void NextGuess()
    {
        
        oldGuess = guess;
        guess = Mathf.FloorToInt(Random.Range(minNum, maxNum));
        guessText.text = guess.ToString();
        GameData.ChosenNumber = guess;
        //Prevents increasing number of attempts after guess is final
        if ((maxNum - minNum) >= 1)
        {
            ++attempts;
            GameData.Attempts = attempts;
        }
        else
        {
            higherBtn.interactable = false;
            lowerBtn.interactable = false;
        }
    }

    public void OnClickHigher()
    {
        minNum = ++guess;
        NextGuess();
    }

    public void OnClickLower()
    {
        maxNum = --guess;
        NextGuess();
    }

}
