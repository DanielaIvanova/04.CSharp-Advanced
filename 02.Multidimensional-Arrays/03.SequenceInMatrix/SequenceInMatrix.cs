using System;
using System.Linq;

class SequenceInMatrix
{
    static void Main()
    {
        /*
       On the first line you will receive the numbers N and M separated by a single space
       On the next N lines there will be M strings separated with spaces - the strings in the matrix
       */

        int[] input = Console.ReadLine()
                      .Split(' ')
                      .Select(int.Parse)
                      .ToArray();
        int n = input[0];
        int m = input[1];
        string[,] matrix = new string[n, m];
        for (int row = 0; row < n; row++)
        {
            string[] currentRow = Console.ReadLine().Split(' ');

            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = currentRow[col];
            }
        }
        Console.WriteLine(LongestSequence(matrix));

    }
        static int LongestSequence(string[,] matrix)
    {
            int currentCount = 1;
            int bestCount = 0;
            string itemMostCounted = string.Empty;

            //check by rows
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row , col+1])
                    {
                        currentCount++;
                    }
                    else
                    {
                        currentCount = 1;
                    }
                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        itemMostCounted = matrix[row, col];
                    }
                }
                currentCount = 1;
            }


            //check by cols
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        currentCount++;
                    }
                    else
                    {
                        currentCount = 1;
                    }
                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        itemMostCounted = matrix[row, col];
                    }
                }
                currentCount = 1;
            }


            //check by diagonal left to right
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                for (int row = 0, column = col; row < matrix.GetLength(0) - 1 && column < matrix.GetLength(1) - 1; row++, column++)
                {
                    if (matrix[row, column] == matrix[row + 1, column + 1])
                    {
                        currentCount++;
                    }
                    else
                    {
                        currentCount = 1;
                    }
                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        itemMostCounted = matrix[row, column];
                    }
                }
                currentCount = 1;
            }
            //check by diagonal right left
            for (int col = matrix.GetLength(1) - 1; col > 0; col--)
            {
                for (int row = 0, column = col; row < matrix.GetLength(0) - 1 && column > 0; row++, column--)
                {
                    if (matrix[row, column] == matrix[row + 1, column - 1])
                    {
                        currentCount++;
                    }
                    else
                    {
                        currentCount = 1;
                    }
                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        itemMostCounted = matrix[row, column];
                    }
                }
                currentCount = 1;
            }
            return bestCount;
        }
    }
