using System;
using System.Numerics;
class StrangeLandNumbers
{
    // 1. read input
    // 2. replace in strangeNumber the words with the numbers
    // 3. convert the strangeNumbers to decimal
        

    static void Main()
    {
        string strangeNumber = Console.ReadLine()
            .Replace("f","0")
            .Replace("bIN","1")
            .Replace("oBJEC","2")
            .Replace("mNTRAVL","3")
            .Replace("lPVKNQ","4")
            .Replace("pNWE","5")
            .Replace("hT","6");

        Console.WriteLine(StrangeNumerToDecimal(strangeNumber));
        
    }

    static BigInteger StrangeNumerToDecimal(string strangeNumber)
    {
        BigInteger sum = 0;

        foreach (var number in strangeNumber)
        {
            sum = (number-'0') + sum * 7;
        }
        return sum;
    }
}

