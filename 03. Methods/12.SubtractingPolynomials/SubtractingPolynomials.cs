using System;
using System.Linq;
class SubtractingPolynomials
{
    static void Main()
    {
        Console.WriteLine();
        int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int[] subtractionArr = Subtraction(firstArr, secondArr);
        Console.WriteLine(string.Join(" ", subtractionArr));

        int[] multiplicationArr = Multiplication(firstArr, secondArr);
        Console.WriteLine(string.Join(" ",multiplicationArr));


    }

    static int[] Subtraction(int[] firstArr, int[] secondArr)
    {
        int[] subArr = new int[firstArr.Length];

        for (int i = 0; i < firstArr.Length; i++)
        {
            subArr[i] = firstArr[i] - secondArr[i];
        }

        return subArr;

    }

    static int[] Multiplication(int[] firstArr,int[]secondArr)
    {
        int[] multiplicationArr = new int[firstArr.Length];

        for (int i = 0; i < firstArr.Length; i++)
        {
            multiplicationArr[i] = firstArr[i] * secondArr[i];
        }

        return multiplicationArr;
    }
}

