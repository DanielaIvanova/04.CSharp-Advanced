using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        string text = Console.ReadLine();

        StringBuilder unicodeLiterals = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            unicodeLiterals.AppendFormat("\\u{0:X4}", (int)text[i]);
        }

        Console.WriteLine(unicodeLiterals.ToString());
    }
}

