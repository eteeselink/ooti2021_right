using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Kiosk.App;


class Ask {
    string question = "";
    List<string> options = new List<string>();
    string answer = "";

    public void Run() {
        //here will collect questions and answers from survey class
        question =  "Are you a human?";
        options = new List<string>() {"yes","no"};
        Console.WriteLine(question);
        int i = 1;
        foreach(string o in options){
            Console.WriteLine(i + ". " + o);
            i += 1;
        }
        Console.WriteLine("Your vote : ");
        string input = Console.ReadLine();
        answer  = options[int.Parse(input) - 1];
    }

    public void setQuestion(string question){
        this.question = question;
    }

    public string getAnswer(){
        return answer;
    }

}