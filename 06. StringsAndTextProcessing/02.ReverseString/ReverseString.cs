using System;
using System.Collections.Generic;

class ReverseString
{
    static void Main()
    {
        string original = Console.ReadLine();
        string reverse = string.Empty;

        for (int i = original.Length - 1; i >= 0; i--)
        {
            reverse += original[i];
        }

        Console.WriteLine(reverse);


    }
}

