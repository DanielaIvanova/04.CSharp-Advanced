using System;
using System.Linq;
class GetLargestNumber
{
    static void Main()
    {
        int[] number = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int num1 = number[0];
        int num2 = number[1];
        int num3 = number[2];

        int maxNumber = GetMax(GetMax(num1, num2), num3);
        Console.WriteLine(maxNumber);

    }
    static int GetMax(int firstNumber, int secondNumber)
    {
        return Math.Max(firstNumber, secondNumber);
    }
}


