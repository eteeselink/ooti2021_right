using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Kiosk.App;

class Results {
    public void Run() {
        Console.WriteLine("dumb");
    }

    public void show(string question, int numOfYes, int numOfNo){
        string s = question + "\n";
        s += "yes: ";
        s += numOfYes.ToString() + "\n";
        s += "no: ";
        s += numOfNo.ToString() + "\n";

        Console.WriteLine(s);
    }
}