using System;
using System.Linq;
class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.ReadLine();
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(FirstLargerElement(numbers));
    }
    static int FirstLargerElement(int[] numbers)
    {
        int index = 0;
        for (int i = 1; i < numbers.Length - 1; i++)
        {
            if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
            {
                index=i;
                break;
            }
            else
            {
                index=-1;
            }
        }
        return index;
    }
}

