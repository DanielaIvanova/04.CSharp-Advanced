using System;

class SumIntegers
{
    static int SumNumbers(string[]integers)
    {
        int sum = 0;

        for (int i = 0; i < integers.Length; i++)
        {
            sum += Convert.ToInt32(integers[i]);
        }

        return sum;
    }


    static void Main()
    {
        string[] integers = Console.ReadLine().Split(' ');
        Console.WriteLine(SumNumbers(integers));
    }
}

