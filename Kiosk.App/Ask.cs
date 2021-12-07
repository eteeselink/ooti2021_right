using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Kiosk.App;


class Ask {
    List<string> questions = new List<string>();
    List<List<string>> options = new List<List<string>>();
    List<string> answers = new List<string>();
    int questionIndex;

    public void Run() {
        //here will collect questions and answers from survey class
        questions =  new List<string>(){"What food do you want to choose?", "Do you like cat or dog?"};
        options.Add(new List<string>() {"pizza", "lahmachun", "bitterballen"});
        options.Add(new List<string>() {"cat", "dog"});
        answers = new List<string>();
        questionIndex = 0;
        nextQuestion();
    }

    public void sendAnswers(){
        //send answers to the survey class
    }

    public void nextQuestion(){
        string question = questions[questionIndex];
        List<string> option = options[questionIndex];
        string answer;
        Console.WriteLine(question);
        int i = 1;
        foreach(string o in option){
            Console.WriteLine(i + ". " + o);
            i += 1;
        }
        Console.WriteLine("Your vote : ");
        answer = Console.ReadLine();
        answers.Add(answer);
        questionIndex += 1;
        if(questionIndex == questions.Count){
            Console.WriteLine("Thanks!");
            sendAnswers();
        }else{
            nextQuestion();
        }
    }
}