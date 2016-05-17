using System;
using System.Linq;

class LargestAreaInMatrix
{
    static void Main()
    {
        /*
        On the first line you will receive the numbers N and M separated by a single space
        On the next N lines there will be M numbers separated with spaces - the elements of the matrix
        */
        int[] input = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        int n = input[0];
        int m = input[1];
        int[,] matrix = new int[n, m];



        for (int row = 0; row < n; row++)
        {
            for (int i = 0; i < length; i++)
            {

            }
        }
    }
}

