using System;
using System.Linq;
class _04_HexadecimalToDecimal
{
    static void Main()
    {
        string hexNumber = Console.ReadLine();
        Console.WriteLine(HexadecimalToDecimal(hexNumber));


    }

    static long HexadecimalToDecimal(string hexNumber)
    {
        long result = 0;
        int power = hexNumber.Length - 1;

        for (int i = 0; i < hexNumber.Length; i++)
        {
            int currentDigit = 0;
            if (hexNumber[i] >= '0' && hexNumber[i] <= '9')
            {
                currentDigit = hexNumber[i] - '0';
            }
            else if (hexNumber[i] >= 'A' && hexNumber[i] <= 'F')
            {
                currentDigit = hexNumber[i] - 'A' + 10;
            }

            result += currentDigit * (long)Math.Pow(16, power);
            power--;
        }

        return result;

        // Console.WriteLine(Convert.ToInt64(Console.ReadLine(), 16));   // or only this code
    }
    
}

