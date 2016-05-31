using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // string durankulak = Console.ReadLine();

        List<string> durankulakDigit = GetDurankulakDigits();
        
        Console.WriteLine(durankulakDigit[26]);

    }
    static List<string> GetDurankulakDigits()
    {
        var digits = new List<string>();
        for (char i = 'A'; i <= 'Z'; i++)
        {
            digits.Add(i.ToString());
        }
        for (char i = 'a'; i <= 'f'; i++)
        {
            for (char j = 'A'; j <= 'Z'; j++)
            {
                digits.Add(i.ToString() + j.ToString());
            }
        }
        return digits;
    }

}

