using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] private Int32 Max;
    [SerializeField] private Int32 Min;
    [SerializeField] private TextMeshProUGUI GuessText;

    private Int32 Guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        UpdateGuess();
    }

    void UpdateGuess()
    {
        Guess = UnityEngine.Random.Range(Min, Max + 1);
        GuessText.text = Guess.ToString();
    }

    public void OnPressHigher()
    {
        Min = Guess + 1;
        UpdateGuess();
    }

    public void OnPressLower()
    {
        Max = Guess - 1;
        UpdateGuess();
    }
}
