using System;
class SeriesOfLetters
{
    static void Main()
    {
        string text = Console.ReadLine();

        string output = string.Empty;
        output += text[0];

        for (int i = 0; i < text.Length-1; i++)
        {
            if (text[i] != text[i+1])
            {
                output +=text[i+1];
            }
        }
        Console.WriteLine(output);
    }
}

