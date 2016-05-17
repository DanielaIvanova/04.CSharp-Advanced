using System;
using System.Linq;
class MaximalSum
{
    static void Main()
    {
        /* 
        On the first line you will receive the numbers N and M separated by a single space
        On the next N lines there will be M numbers separated with spaces -the elements of the matrix
        */

        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = input[0];
        int m = input[1];

        int[,] matrix = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            string[] currentLine = Console.ReadLine().Split(' ');
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(currentLine[j]);
            }
        }



        //logic
        int width = 3;
        int height = 3;
        long bestSum = long.MinValue;

        for (int row = 0; row < matrix.GetLength(0) - height + 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - width + 1; col++)
            {
                int sum = 0;
                for (int platformRow = row; platformRow < row + height; platformRow++)
                {
                    for (int platformCol = col; platformCol < col + width; platformCol++)
                    {
                        sum += matrix[platformRow, platformCol];
                    }
                }
                if (sum > bestSum)
                {
                    bestSum = sum;
                }
            }
        }

        //print result
        Console.WriteLine(bestSum);
    }
}

