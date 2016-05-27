using System;
using System.Text;
class ReverseSentence
{
    static void Main()
    {
        //        Input                                         Output
        //C# is not C++, not PHP and not Delphi! 	Delphi not and PHP, not C++ not is C#!

        var text = "C# is not C++, not PHP and not Delphi!"; //Console.ReadLine();

        char lastSign = text[text.Length - 1];
        var revercedText = new StringBuilder(text.Length);

        string[] allWords = text
            .Substring(0, text.Length - 1)
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = allWords.Length - 1; i >= 0; i--)
        {
            if (allWords[i].Contains(","))
            {
                // replace , with "" in allWords[i]
                allWords[i] = allWords[i].Replace(",", "");
                allWords[i + 1] = ", " + allWords[i + 1];
            }
        }

        Array.Reverse(allWords);

        // output
        Console.Write(allWords[0]);
        for (int i = 1; i < allWords.Length; i++)
        {
            if (allWords[i].Contains(","))
            {
                Console.Write(allWords[i]);
            }
            else
            {
                Console.Write(" " + allWords[i]);
            }
        }
        Console.WriteLine(lastSign);
        //Delphi not and PHP, not C++ not is C#!


    }
}

