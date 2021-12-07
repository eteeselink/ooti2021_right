using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Kiosk.App;

class Survey {

    private String question = "dummy question?...";
    private List<string> options;
    private int[] responseCount = {0,0};



    public void Run() {

        // get the question /////////////////////////
        String answer = "";
        Read read = new Read();
        Question q = read.GetQuestion();
        question = q.question;
        this.options = q.options;


        Ask ask = new Ask();
        ask.setQuestion(q);


        for(int i = 0; i < 5; i++)
        {
            ask.Run();
            answer = ask.getAnswer();

            Console.WriteLine(answer);

        }





        
        //Console.WriteLine("Survey: getting questionaire from read module");
        //Console.WriteLine("Survey: asking user 1");
        //Console.WriteLine("Survey: asking user 2");
        //Console.WriteLine("Survey: asking user 3");
    }



    private void getQuestions()
    {

    }
}