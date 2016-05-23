using System;
using System.Collections.Generic;

class HexadecimalToBinary
{
    static void Main()
    {
        string number = Console.ReadLine();
        Console.WriteLine(HexToBinNumber(number));
    }
    static Dictionary<char, string> HexToBinDigit = new Dictionary<char, string>()
    {
        {'0',"0000"},
        {'1',"0001"},
        {'2',"0010"},
        {'3',"0011"},
        {'4',"0100"},
        {'5',"0101"},
        {'6',"0110"},
        {'7',"0111"},
        {'8',"1000"},
        {'9',"1001"},
        {'A',"1010"},
        {'B',"1011"},
        {'C',"1100"},
        {'D',"1101"},
        {'E',"1110"},
        {'F',"1111"}
    };

    static string HexToBinNumber(string number)
    {
        string result = "";
        foreach (char digit in number)
        {
            result += HexToBinDigit[digit];
        }

        return result.TrimStart('0'); // remove '0' infront the number
    }
}


