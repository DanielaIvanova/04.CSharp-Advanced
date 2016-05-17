//Write a program that finds the length of the maximal increasing sequence in an array of N integers.

using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int count = 1;
        int lengthCount = 0;

        for (int i = 0; i < arr.Length-1; i++)
        {
            if (arr[i] < arr[i + 1])
            {
                count++;
                lengthCount = Math.Max(count, lengthCount);
            }
            else
            {
                count = 1;
            }
           
        }
        Console.WriteLine(lengthCount);
    }
}

