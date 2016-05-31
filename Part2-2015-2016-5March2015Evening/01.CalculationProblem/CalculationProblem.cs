using System;
using System.Linq;


class CalculationProblem
{

    // 1.read input
    // 2.convert every number to it's decimal value
    // 3.sum all the numbers
    // 4.convert the sum to meow numeral system
    // 5.print the result


    static void Main()
    {
        var catNumbers = Console.ReadLine().Split(' ').Select(CatToDecimal).ToArray();
        //Console.WriteLine(String.Join("\r\n", catNumers));   ---> check how is working the input

        long sum = 0;
        foreach (var n in catNumbers)
        {
            sum += n;
        }

        var answer = DecimalToCat(sum) + " = " + sum;
        Console.WriteLine(answer);


    }
    static long CatToDecimal(string catNumber)
    {
        long sum = 0;

        foreach (char digit in catNumber)
        {
            sum = (digit - 'a') + sum * 23;
        }

        return sum;
    }

    static string DecimalToCat(long dec)
    {
        string result = string.Empty;
        do
        {
            char digit = (char)((dec % 23) + 'a');
            result = digit + result;
            dec /= 23;

        } while (dec != 0);
        return result;
    }
}

