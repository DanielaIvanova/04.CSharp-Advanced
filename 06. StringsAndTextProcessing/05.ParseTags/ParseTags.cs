﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class ParseTags
{
    static void Main()
    {
        string text = Console.ReadLine();

        Console.WriteLine(Regex.Replace(text, "<upcase>(.*?)</upcase>", word => word.Groups[1].Value.ToUpper()));


    }


}

