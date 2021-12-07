using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Kiosk.App;

public class Report {
    public void Run() {
        Console.WriteLine("Report");
        
    }
}

private string CreateHtmlContent(){
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
<li>
<span></span>
<span></span>
</li>
        </ul>
        </div>
        </body>
        </<html>";
}