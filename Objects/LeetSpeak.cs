using System;
using System.Collections.Generic;

namespace LeetSpeak
{
  public class LeetSpeak
  {
    private string _inputtedString;

    public LeetSpeak(string InputtedString)
    {
      _inputtedString = InputtedString;
    }


    public string Translate(string InputtedString)
    {
      char[] arrayOfLetters = InputtedString.ToCharArray();
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
      string result = string.Join("", arrayOfLetters);
      System.Console.WriteLine(result);
      return result;
    }
  }
}
