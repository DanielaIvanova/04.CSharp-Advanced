using System;

class Digits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] digit = new int[n, n];
        for (int row = 0; row < n; row++)
        {
            string[] currentLine = Console.ReadLine().Split(' ');
            for (int col = 0; col < currentLine.Length; col++)
            {
                digit[row, col] = int.Parse(currentLine[col]);
            }
        }

        for (int row = 0; row <= n-5; row++)
        {
            for (int col = 0; col <= n-3; col++)
            {

            }
        }
    }
}

