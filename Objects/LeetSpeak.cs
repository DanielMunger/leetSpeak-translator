using System;
using System.Collections.Generic;

namespace LeetSpeak.Object
{
  public class LeetSpeakTranslator
  {
    private string _inputtedString;

    public LeetSpeakTranslator(string InputtedString)
    {
      _inputtedString = InputtedString;
    }


    public string Translate(string Input)
    {
      string[] userInput = Input.Split(' ');
      string result = "";
      for (int j = 0; j < userInput.Length; j++)
      {
        string word = userInput[j];
        char[] arrayOfLetters = word.ToCharArray();
        for(int i = 0; i < arrayOfLetters.Length; i++)
        {
          if(arrayOfLetters[i] == 'e' || arrayOfLetters[i] == 'E')
          {
            arrayOfLetters[i] = '3';
          }
          if(arrayOfLetters[i] == 'i')
          {
            arrayOfLetters[i] = '1';
          }
          if((arrayOfLetters[i] == 's' || arrayOfLetters[i] == 'S') &&  i !=0)
          {
            arrayOfLetters[i] = 'z';
          }
        }
        if (j != 0 && j < userInput.Length)
        {
        result += (" " + string.Join("", arrayOfLetters));
        }
        else
        {
        result += string.Join("", arrayOfLetters);
        }
      }
      return result;
    }
  }
}
