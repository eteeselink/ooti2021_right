using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Kiosk.App;


class Ask {
    Question question;
    string answer = "";

    public void Run() {
        //here will collect questions and answers from survey class
        Console.WriteLine(question.questionTitle);
        int i = 1;
        foreach(string o in question.options){
            Console.WriteLine(i + ". " + o);
            i += 1;
        }
        Console.WriteLine("Your vote : ");
        string input = Console.ReadLine();
        answer  = options[int.Parse(input) - 1];
    }

    public void setQuestion(Question question){
        this.question = question;
    }

    public string getAnswer(){
        return answer;
    }

}