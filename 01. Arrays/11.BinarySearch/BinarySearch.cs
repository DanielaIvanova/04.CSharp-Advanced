/*Write a program that finds the index of given element X in a sorted array of N integers by using the Binary search algorithm.
Input

    On the first line you will receive the number N
    On the next N lines the numbers of the array will be given
    On the last line you will receive the number X

Output

    Print the index where X is in the array
        If there is more than one occurence print the first one
        If there are no occurences print -1
*/

using System;

class BinarySearch
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int numberX = int.Parse(Console.ReadLine());

        int counter = 0;
        int startIndex = 0;
        int endIndex = length - 1;
        int midIndex = (endIndex - startIndex) / 2;
        int result = -1;

        while (counter <= length / 2)
        {
            if (arr[midIndex] == numberX)
            {
                result = midIndex;
                break;
            }
            else if (arr[midIndex] < numberX)
            {
                startIndex = midIndex + 1;
                midIndex = (endIndex + startIndex) / 2;
                counter++;
            }
            else
            {
                endIndex = midIndex - 1;
                midIndex = (startIndex + endIndex) / 2;
                counter++;
            }
        }

        Console.WriteLine(result);
    }
}


