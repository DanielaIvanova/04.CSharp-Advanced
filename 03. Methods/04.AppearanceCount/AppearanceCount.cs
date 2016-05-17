using System;
using System.Linq;
class AppearanceCount
{
    static void Main()
    {
        /*
        On the first line you will receive the number N -the size of the array
        On the second line you will receive N numbers separated by spaces -the array
        */
        Console.ReadLine();
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); 
        
        
             
        int surchingNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(Count(array,surchingNumber));
    }
    static int Count(int[]array,int surchingNumber)
    {
        int counter = 0;
        foreach (var number in array)
        {
            if (number==surchingNumber)
            {
                counter++;
            }
        }
        return counter;
        
    }
}

