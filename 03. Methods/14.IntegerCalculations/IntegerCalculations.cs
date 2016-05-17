using System;
using System.Linq;
class IntegerCalculations
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(Min(array));
        Console.WriteLine(Max(array));
        Console.WriteLine("{0:F2}", Average(array));
        Console.WriteLine(Sum(array));
        Console.WriteLine(Product(array));
    }
    static int Min(int[] array)
    {
        int min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
            }
        }
        return min;
    }

    static int Max(int[] array)
    {
        int max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
        }
        return max;
    }
    static double Average(int[] array)
    {
        int sum = 0;
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            counter++;
        }
        double avarage = (double)sum / counter;
        return avarage;
    }
    static long Sum(int[] array)
    {
        long sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
    static long Product(int[] array)
    {
        long product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];

        }
        return product;
    }
}
