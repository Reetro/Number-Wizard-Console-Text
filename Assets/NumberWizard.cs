using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
  // Start is called before the first frame update
  int max;
  int min;
  int guess;

  void Start()
  {
    StartGame();
  }

  void StartGame()
  {
    max = 1000;
    min = 1;
    guess = 500;

    Debug.Log("Yo man welcome to number wizard");
    Debug.Log("Pick a number. Don't tell me what is.");
    Debug.Log("Highest number you can pick is: " + max);
    Debug.Log("Lowest number you can pick is: " + min);
    Debug.Log("Tell me if your number is lower or higher than " + guess);
    Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
    max++;
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.UpArrow))
    {
      min = guess;
      NextGuess();
    }

    else if (Input.GetKeyDown(KeyCode.DownArrow))
    {
      max = guess;
      NextGuess();
    }

    else if (Input.GetKeyDown(KeyCode.Return))
    {
      Debug.Log("I has big brain ( ͡° ͜ʖ ͡°)");

      StartGame();
    }
  }

  void NextGuess()
  {
    guess = (max + min) / 2;
    Debug.Log("Is it higher or lower than.." + guess);
  }
}
