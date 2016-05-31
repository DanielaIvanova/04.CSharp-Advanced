using System;
using System.Linq;

class LoverOf3
{
    static void Main()
    {
        var fieldSizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var rowsCount = fieldSizes[0];
        var colsCount = fieldSizes[1];

        var field = new bool[rowsCount, colsCount];

        var n = int.Parse(Console.ReadLine());

        long result = 0;

        int row = rowsCount - 1;
        int col = 0;
        int currentCell = 0;

        for (int i = 0; i < n; i++)
        {
            var move = Console.ReadLine().Split(' ');

            var direction = move[0];
            var repeats = int.Parse(move[1]);

            var deltaRow = direction.Contains("U") ? -1 : 1;
            var deltaCow = direction.Contains("L") ? -1 : 1;

            // could also be from 0 to repeats - 1
            for (int j = 1; j < repeats; j++)
            {
                if (IsInside(row + deltaRow, col + deltaCow, field))
                {
                    // go to the cell
                    row += deltaRow;
                    col += deltaCow;

                    if (deltaRow == -1 && deltaCow == 1)
                    {
                        currentCell += 6;
                    }
                    else if (deltaRow == 1 && deltaCow == -1)
                    {
                        currentCell -= 6;
                    }

                    // if not collected
                    if (!field[row, col])
                    {
                        result += currentCell;
                        field[row, col] = true;
                    }
                }
                else
                {
                    break;
                }

            }
        }

        Console.WriteLine(result);
    }

    static bool IsInside(int row, int col, bool[,] matrix)
    {
        bool rowIsInField = 0 <= row && row < matrix.GetLength(0);
        bool colIsInField = 0 <= col && col < matrix.GetLength(1);

        return rowIsInField && colIsInField;
    }
}


