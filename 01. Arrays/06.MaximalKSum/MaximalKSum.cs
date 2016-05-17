/*Write a program that reads two integer numbers N and K and an array of N elements from the console. Find the maximal sum of K elements in the array.
Input

    On the first line you will receive the number N
    On the second line you will receive the number K
    On the next N lines the numbers of the array will be given

Output

    Print the maximal sum of K elements in the array

Constraints

    1 <= N <= 1024
    1 <= K <= N
    Time limit: 0.1s
    Memory limit: 16MB
*/

using System;

class MaximalKSum
{
    static void Main()
    {
        //read input
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        
        int sum = 0;

        //logic

        Array.Sort(arr);
        Array.Reverse(arr);

        for (int i = 0; i < k; i++)
        {
            sum += arr[i];
        }

        //print result
        Console.WriteLine(sum);

    }
}

