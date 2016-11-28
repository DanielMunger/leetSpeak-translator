using Xunit;
using System;

namespace LeetSpeak
{
  public class LeetSpeakTest
  {
    [Fact]
    public void _TranslateLeetSpeak_true()
    {

      LeetSpeak newLeetWord = new LeetSpeak("ideas");
      string testWord = newLeetWord.Translate("ideas");
      Assert.Equal(true, testWord == "1d3az");
      
    }
  }
}
