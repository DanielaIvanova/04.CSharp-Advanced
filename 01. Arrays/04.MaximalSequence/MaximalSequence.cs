//Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.

using System;

class Program
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

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i - 1] == arr[i])
            {
                count++;
                lengthCount = Math.Max(lengthCount, count);
            }
            else
            {
                count = 1;
            }
        }
        Console.WriteLine(lengthCount);


    }
}

