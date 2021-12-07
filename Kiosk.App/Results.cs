using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Kiosk.App;

class Results {
    public void Run() {
        Console.WriteLine("dumb");
    }

    //yes/no question
    public static void show(string question, int numOfYes, int numOfNo){
        string s = "\n\n=========RESULTS=========\n\n";
        s += question + "\n";
        s += "yes: ";
        s += numOfYes.ToString() + "\n";
        s += "no: ";
        s += numOfNo.ToString() + "\n";

        Console.WriteLine(s);
    }

    //many options
    public static void showMany(string question, IDictionary<string, int> optionVotes){
        string s = "\n\n=========RESULTS=========\n\n";
        s += question + "\n";

        foreach (var option in optionVotes)
        {
            s += option.Key + ": " + option.Value + "\n";
        }

        Console.WriteLine(s);
    }
}