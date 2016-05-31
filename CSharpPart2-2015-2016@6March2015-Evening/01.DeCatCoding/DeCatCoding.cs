using System;
using System.Linq;

class DeCatCoding
{
    // 1. read input
    //   1.1. extract all cat numers from the input
    // 2. convert all cat numbers from 21 - based numeral to decimal
    // 3. convert all decimal numbers to 26 - based numeral
    // 4. join by space and print

    static long CatToDec(string catWord)
    {
        long sum = 0;

        foreach (char letter in catWord)
        {
            sum = (long)(letter - 'a' + sum * 21);
        }

        return sum;
    }

    static string DecToCat(long number)
    {
        var result = string.Empty;

        do
        {
            char digit = (char)('a' + (number % 26));
            result = digit + result;
            number /= 26;

        } while (number > 0);

        return result;
    }

    static void Main()
    {
        var catWords = Console.ReadLine().Split().Select(CatToDec).Select(DecToCat).ToArray();
       
        Console.WriteLine(string.Join(" ",catWords));
    }
}

