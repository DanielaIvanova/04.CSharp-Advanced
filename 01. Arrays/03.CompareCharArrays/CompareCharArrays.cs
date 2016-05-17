﻿//Write a program that compares two char arrays lexicographically (letter by letter).

using System;
using System.Linq;

class CompareCharArrays
{
    static void Main()
    {

        string first = Console.ReadLine();
        string second = Console.ReadLine();

        int loopLength = Math.Min(first.Length, second.Length);

        for (int i = 0; i < loopLength; i++)
        {
            if (first[i] > second[i] || i == loopLength - 1 && first.Length > second.Length)
            {
                Console.WriteLine(">");
                return;
            }
            else if (first[i] < second[i] || i == loopLength - 1 && first.Length < second.Length)
            {
                Console.WriteLine("<");
                return;
            }
            else if (i == loopLength - 1 && first.Length == second.Length)
            {
                Console.WriteLine("=");
            }
        }

    }
   
}

