using System;
class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter array's lenght: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter [{0}] element: ",i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        Array.Sort(array);
        int binarySearched = Array.BinarySearch(array, k);

        if (binarySearched < -1)
        {
            Console.WriteLine($"The nearest number to {k} is {array[~binarySearched - 1]}");
        }
        else if (~binarySearched == 0)
        {
            Console.WriteLine("Such number does not exist!");
        }
        else
        {
            Console.WriteLine($"The array contains the searching number K = {k}");
        }
    }
}

