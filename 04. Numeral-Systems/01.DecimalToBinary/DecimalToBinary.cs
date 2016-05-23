using System;

class _02_DecimalToBinary
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine(DecimalToBinary(number));
    }

    static string DecimalToBinary(long decValue)
    {
        string binary = "";
        while (decValue != 0)
        {
            long bit = decValue % 2;
            binary = bit + binary;
            decValue /= 2;
        }

        return binary;

        //Console.WriteLine(Convert.ToString(Int64.Parse(Console.ReadLine()), 2));  //or only this code
    }
}

