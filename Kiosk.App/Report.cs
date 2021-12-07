using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Kiosk.App;

public class Report
{
    public void Run()
    {
        Console.WriteLine("Report");


        WriteToFile("This is a test");
    }




    private void WriteToFile(String htmlText)
    {
        var rootDir = AppContext.BaseDirectory + "/../../../../";

        string fileName = rootDir + "report.html";

        try
        {
            // Check if file already exists. If yes, delete it.     
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            // Create a new file     
            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine(htmlText);
            }
        }
        catch (Exception Ex)
        {
            Console.WriteLine(Ex.ToString());
        }
    }
}