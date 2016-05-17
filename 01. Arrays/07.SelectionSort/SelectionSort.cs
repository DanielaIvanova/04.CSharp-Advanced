/*Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
Input

    On the first line you will receive the number N
    On the next N lines the numbers of the array will be given

Output

    Print the sorted array
        Each number should be on a new line

Constraints

    1 <= N <= 1024
    Time limit: 0.1s
    Memory limit: 16MB
*/

using System;

class SelectionSort
{
    static void Main()
    {
        //read input
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        //logic
        int minElement = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            minElement = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minElement])
                {
                    minElement = j;
                }
            }
            if (minElement != i)
            {
                int temp = arr[i];
                arr[i] = arr[minElement];
                arr[minElement] = temp;
            }

            Console.WriteLine(arr[i]);
            if (i == n - 2)
            {
                Console.WriteLine(arr[i + 1]);
            }

        }




    }
}

