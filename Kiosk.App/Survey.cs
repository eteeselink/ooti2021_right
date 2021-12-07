using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Kiosk.App;

class Survey {

    private String question = "dummy question?...";
    private List<string> options;
    private int[] responseCount = {};

    private int yesCounter = 0;
    private int noCounter = 0;



    public void Run() {

        // get the question /////////////////////////
        String answer = "";
        Read read = new Read();
        Question q = read.GetQuestion();
        question = q.question;
        this.options = q.options;


        Ask ask = new Ask();
        ask.setQuestion(q);


        while(true)
        {
            ask.Run();
            answer = ask.getAnswer();

            if(answer.Equals("Yes")){
                yesCounter = yesCounter + 1;

            }
            else if(answer.Equals("No"))
            {
               noCounter++;
            }

            Console.WriteLine(answer);

            // get results
        Results.show(q.question, yesCounter, noCounter);

        Report rep = new Report(q.question, yesCounter, noCounter);

        rep.Run();

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