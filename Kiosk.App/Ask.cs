using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Kiosk.App;


class Ask {
    Question question;
    string answer = "";

    public void Run() {
        //here will display the question and record the answer
        try{
            Console.WriteLine(question.question);
            int i = 1;
            foreach(string o in question.options){
                Console.WriteLine(i + ". " + o);
                i += 1;
            }
            Console.WriteLine("Your vote : ");
            string input = Console.ReadLine();
            question.answer  = question.options[int.Parse(input) - 1];
        }catch(Exception e){}
    }

    public void setQuestion(Question question){
        this.question = question;
    }

    public string getAnswer(){
        return question.answer;
    }

}