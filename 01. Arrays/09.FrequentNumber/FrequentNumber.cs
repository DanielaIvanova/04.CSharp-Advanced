/*Write a program that finds the most frequent number in an array of N elements.
Input

    On the first line you will receive the number N
    On the next N lines the numbers of the array will be given

Output

    Print the most frequent number and how many time it is repeated
        Output should be REPEATING_NUMBER (REPEATED_TIMES times)
        */


using System;
class FrequentNumber
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
        int bestCounter = 0;
        int counter = 1;
        int value = 0;
        //sorting the array. The elements with same value will be placed next to each outher
        Array.Sort(arr);

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                counter++;

            }
            else
            {
                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    value = arr[i];
                }
                counter = 1;
            }
        }
        // in case when the last sequence is the maximal sequence of equal elements
        if (counter > bestCounter)
        {
            bestCounter = counter;
            value = arr[arr.Length - 1];
        }

        // output
        Console.WriteLine("{0} ({1} times)", value, bestCounter);


    }

}


