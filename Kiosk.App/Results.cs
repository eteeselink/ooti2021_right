using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Kiosk.App;

class Results {
    public void Run() {
        string question = "What do you want to choose?";
        IDictionary<string, int> choiceVotes = new Dictionary<string, int>();

        choiceVotes.Add("pizza", 5);
        choiceVotes.Add("lahmacun", 2);
        choiceVotes.Add("bitterballen", 8);

        string s = "Q: " + question + "\n";
        foreach (var choice in choiceVotes)
        {
            s += choice.Key;
            s += " - ";
            s += choice.Value;
            s += "\n";
        }

        
        Console.WriteLine(s);
    }
}