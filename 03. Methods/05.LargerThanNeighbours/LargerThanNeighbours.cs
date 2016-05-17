//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist). Write program that reads an array of numbers and prints how many of them are larger than their neighbours.

using System;
using System.Linq;
class LargerThanNeighbours
{
    static void Main()
    {
        /*
          On the first line you will receive the number N - the size of the array
          On the second line you will receive N numbers separated by spaces - the array
        */
        Console.ReadLine();
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(LargerElement(array));
    }
    static int LargerElement(int[] array)
    {
        int counter = 0;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                counter++;
            }
        }
        return counter;
    }
}

