using Xunit;
using System;
using LeetSpeak.Object;

namespace LeetSpeak
{
  public class LeetSpeakTest
  {
    [Fact]
    public void _TranslateLeetSpeak_true()
    {

      LeetSpeakTranslator newLeetWord = new LeetSpeakTranslator("ideas sies");
      string testWord = newLeetWord.Translate("ideas sies");
      System.Console.WriteLine("'" + testWord + "'");
      Assert.Equal(true, testWord == "1d3az s13z");

    }
  }
}
