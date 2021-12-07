using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Kiosk.App;

class Question {
    public string question {get;set;}
    public List<string> options{get;set;}
    public string answer {get;set;}
}