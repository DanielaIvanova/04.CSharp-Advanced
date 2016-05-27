using System;
using System.Collections.Generic;

class WordDictionary
{
    static void Main()
    {
        //.NET platform for applications from Microsoft
        //CLR     managed execution environment for .NET
        //namespace hierarchical organization of classes

        var dictanary = new Dictionary<string, string>()
        {
            {".NET","platform for applications from Microsoft" },
            {"CLR", "managed execution environment for .NET" },
            { "namespace", "hierarchical organization of classes"}

        };

        var input = Console.ReadLine();
        Console.WriteLine(dictanary[input]);
    }
}

