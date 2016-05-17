using System;
using System.Linq;
class SolveTasks
{
    static void Main()
    {
        Console.WriteLine("Enter which task you would like to solve!");
        Console.WriteLine("Enter 1 - For reverses the digits of a number");
        Console.WriteLine("Enter 2 - For calculates the average of a sequence of integers");
        Console.WriteLine("Enter 3 - For solves a linear equation");
        int choosenTask = int.Parse(Console.ReadLine());

        switch (choosenTask)
        {
            case 1:
                Console.WriteLine("Enter numer to reverse: ");
                string toReverse = Console.ReadLine();
                if (toReverse[0] == '-')
                {
                    Console.WriteLine("Please enter positiv number!");
                    toReverse = Console.ReadLine();
                }
                Console.WriteLine(ReverseDigit(toReverse));
                break;
            case 2:
                Console.WriteLine("Enter sequence of integer numbers: ");
                int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Console.WriteLine(AverageOfSequence(array));
                break;
            case 3:
                Console.WriteLine("a*x + b = 0");
                Console.WriteLine("Enter a: ");
                int a = int.Parse(Console.ReadLine());
                while (a==0)
                {
                    Console.WriteLine("A should be not equal to zero!");
                    Console.WriteLine("Please enter a: ");
                    a = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter b: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("x = {0:F2}", LinearEquation(a,b));
                break;
        }

    }

    static string ReverseDigit(string toRevese)
    {
        char[] array = toRevese.ToCharArray();
        string reversed = string.Empty;

        for (int i = array.Length - 1; i >= 0; i--)
        {
            reversed += array[i];

        }
        return reversed;
    }

    static double AverageOfSequence(int[] array)
    {
        int sum = 0;
        int br = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            br++;
        }
        double averageSum = (double)sum / br;
        return averageSum;
    }

    static double LinearEquation(int a, int b)
    {
        double x =(double) -b / a;
        return x;
    }
}

