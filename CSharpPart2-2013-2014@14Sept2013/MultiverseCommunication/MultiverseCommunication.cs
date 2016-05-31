using System;

class MultiverseCommunication
{
    // 1. read input
    // 2. replace the input with the digits
    // 3. convert to from 13 to decimal
    static void Main()
    {
        string parallelUniverse = Console.ReadLine()
            .Replace("CHU", "0")
            .Replace("TEL", "1")
            .Replace("OFT", "2")
            .Replace("IVA", "3")
            .Replace("EMY", "4")
            .Replace("VNB", "5")
            .Replace("POQ", "6")
            .Replace("ERI", "7")
            .Replace("CAD", "8")
            .Replace("K-A", "9")
            .Replace("IIA", "A")
            .Replace("YLO", "B")
            .Replace("PLA", "C");

        Console.WriteLine(ParUnToDecimal(parallelUniverse));
    }

    static long ParUnToDecimal(string parallelUniverse)
    {
        long result = 0;
        int power = parallelUniverse.Length - 1;

        for (int i = 0; i < parallelUniverse.Length; i++)
        {
            int currentDigit = 0;
            if (parallelUniverse[i] >= '0' && parallelUniverse[i] <= '9')
            {
                currentDigit = parallelUniverse[i] - '0';

            }
            else if (parallelUniverse[i] >= 'A' && parallelUniverse[i] <= 'C')
            {
                currentDigit = parallelUniverse[i] - 'A' + 10;
            }
            result += currentDigit * (long)Math.Pow(13, power);
            power--;
        }
        return result;
    }
}
//static long HexadecimalToDecimal(string hexNumber)
//{
//    long result = 0;
//    int power = hexNumber.Length - 1;

//    for (int i = 0; i < hexNumber.Length; i++)
//    {
//        int currentDigit = 0;
//        if (hexNumber[i] >= '0' && hexNumber[i] <= '9')
//        {
//            currentDigit = hexNumber[i] - '0';
//        }
//        else if (hexNumber[i] >= 'A' && hexNumber[i] <= 'F')
//        {
//            currentDigit = hexNumber[i] - 'A' + 10;
//        }

//        result += currentDigit * (long)Math.Pow(16, power);
//        power--;
//    }

//    return result;
