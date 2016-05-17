using System;
class ReverseNumber
{
    static void Main()
    {
        string number =Console.ReadLine();

        Console.WriteLine(ReverseNum(number));
    }

    static string ReverseNum (string number)
    {
        string reversed = string.Empty;
        for (int i = number.Length-1; i >=0; i--)
        {
            reversed += number[i];
        }
        return reversed;
    }
}

