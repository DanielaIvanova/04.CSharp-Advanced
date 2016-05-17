/*Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.

    Can you do it with only one loop (with single scan through the elements of the array)?

Input

    On the first line you will receive the number N
    On the next N lines the numbers of the array will be given

Output

    Print the maximal sum of consecutive numbers

Constraints

    1 <= N <= 1024
    Time limit: 0.1s
    Memory limit: 16MB
*/

using System;

class MaximalSum
{
    static void Main()
    {
        //read input
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int maxSum = 0;
        int currentSum = 0;

        //logic
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            currentSum += arr[i];

            if (currentSum < arr[i])
            {
                currentSum = arr[i];
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }
        //print result
        Console.WriteLine(maxSum);
    }

}


