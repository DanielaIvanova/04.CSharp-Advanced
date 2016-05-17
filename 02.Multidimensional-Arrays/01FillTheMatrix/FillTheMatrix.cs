using System;
class FillTheMatrix
{
    static void Main()
    {
        //read input
        int n = int.Parse(Console.ReadLine());
        char letter = char.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        if (letter == 'a')
        {
            matrix = TypeMatrixA(matrix);
            PrintTheMatrix(matrix);
        }
        if (letter == 'b')
        {
            matrix = TypeMatrixB(matrix);
            PrintTheMatrix(matrix);
        }
        if (letter == 'c')
        {
            matrix = TypeMatrixC(matrix);
            PrintTheMatrix(matrix);
        }
        if (letter == 'd')
        {
            matrix = TypeMatrixD(matrix);
            PrintTheMatrix(matrix);
        }

    }

    //letter 'a'
    /* 1 4 7       cols  -> right to left
       2 5 8       rows  -> top to bottom
       3 6 9
     */
    static int[,] TypeMatrixA(int[,] matrix)
    {
        int print = 1;
        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                matrix[col, row] = print;
                print++;
            }

        }
        return matrix;
    }

    //letter 'b'
    /* 1 6 7      even cols  -> top to bottom
       2 5 8      odd  cols  -> bottom to top
       3 4 9  
     */
    static int[,] TypeMatrixB(int[,] matrix)
    {
        int print = 1;
        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            //even cols
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    matrix[col, row] = print;
                    print++;
                }
            }
            //odd cols
            else
            {
                for (int row = matrix.GetLength(1) - 1; row >= 0; row--)
                {
                    matrix[col, row] = print;
                    print++;
                }
            }
        }
        return matrix;
    }

    //letter 'c'
    /* 4 7 9 
       2 5 8 
       1 3 6
     */
    static int[,] TypeMatrixC(int[,] matrix)
    {
        int print = 1;

        // Print lower left side

        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        {
            for (int col = 0; col < matrix.GetLength(0) - row; col++)
            {
                matrix[col, row + col] = print;
                print++;
            }

        }
        // Print upper right side

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 1; col < matrix.GetLength(1) - row; col++)
            {
                matrix[col + row, col - 1] = print;
                print++;
            }
        }
        return matrix;
    }

    //letter 'd'
    /* 1 8 7
       2 9 6
       3 4 5
     */
    static int[,] TypeMatrixD(int[,] matrix)
    {
        int print = 1;

        // Add left side to down

        for (int col = 0; col < 1; col++)
        {
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                matrix[col, row] = print;
                print++;
            }
        }

        // Add bottom side to right

        for (int col = 0; col < 1; col++)
        {
            for (int row = 0; row < matrix.GetLength(1) - 1; row++)
            {
                matrix[row + 1, matrix.GetLength(0) - 1] = print;
                print++;
            }
        }
        for (int col = 0; col < 1; col++)
        {
            for (int row = matrix.GetLength(0)-1; row >=0 ; row--)
            {
                matrix[matrix.GetLength(0)-1,-row] = print;
                print++;
            }
        }
        /* започвате от позиция (0,0) и се движите надолу N пъти. След това се движите надясно N-1 пъти, след това нагоре N-1 пъти, след това наляво N-2 пъти, след това надолу N-2 пъти и т.н. При всяко преместване слагате в клетката, която напускате поредното число 1, 2, 3, ..., N.*/
     
        //  // Add right side to up
        //  for (int col = matrix.GetLength(0) - 1; col > matrix.GetLength(0) - 2; col--)
        //  {
        //      for (int row = matrix.GetLength(1) - 2; row >= 0; row--)
        //      {
        //          matrix[col, row] = print;
        //          print++;
        //      }
        //  }
        //
        //  //Add top side to left
        //  for (int col = matrix.GetLength(0) - 1; col > matrix.GetLength(0) - 2; col--)
        //  {
        //      for (int row = matrix.GetLength(1) - 2; row >= 0; row--)
        //      {
        //          matrix[row + 1, matrix.GetLength(0)-col] = print;
        //          print++;
        //      }
        //  }
        return matrix;

    }


    //print the matrix
    static int[,] PrintTheMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(1); row++)
        {
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                Console.Write(matrix[col, row]);

                if (col != matrix.GetLength(0) - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        return matrix;
    }


}
