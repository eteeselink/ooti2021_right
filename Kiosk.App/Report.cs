using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Kiosk.App;

public class Report
{
    public void Run()
    {
        Console.WriteLine("Report is ready!");
        string htmlContent = CreateHtmlContent();
        WriteToFile(htmlContent);
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

    private string CreateHtmlContent()
    {
        string htmlContent = @"<html>
        <body>
        <div>
        <ul>
<li>
<span>Pizza</span>
<span>12</span>
</li>
<li>
<span>Hambuger</span>
<span>6</span>
</li>
<li>
<span>Spagetti</span>
<span>11</span>
</li>
<li>
<span>Iranian Food</span>
<span>30</span>
</li>
<li>
<span>Dutch Food</span>
<span>Are you kidding me?</span>
</li>
        </ul>
        </div>
        </body>
        </html>";
        return htmlContent;
    }
}
