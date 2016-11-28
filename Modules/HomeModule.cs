using Nancy;
using System.Collections.Generic;
using LeetSpeak.Object;

namespace LeetSpeak
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Post["/submit"] = _ => {
        string userInput = Request.Form["UserInput"];
        LeetSpeakTranslator translator = new LeetSpeakTranslator(userInput);
        string translatedInput = translator.Translate(userInput);
        return View["index.cshtml", translatedInput];
      };
    }
  }
}
