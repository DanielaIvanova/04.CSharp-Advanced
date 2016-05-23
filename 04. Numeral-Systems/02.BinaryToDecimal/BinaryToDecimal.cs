using System;

class _01_BinaryToDecimal
{

    static void Main()
    {
        string binary = Console.ReadLine();
        Console.WriteLine(BinaryToDecimal(binary));
    }

    static long BinaryToDecimal(string binary)
    {
        long sum = 0;

        foreach (char bit in binary)
        {
            sum = (bit - '0') + sum * 2;
        }

        return sum;

        // Console.WriteLine(Convert.ToUInt64(Console.ReadLine(), 2).ToString());  //or only this code
    }
}

