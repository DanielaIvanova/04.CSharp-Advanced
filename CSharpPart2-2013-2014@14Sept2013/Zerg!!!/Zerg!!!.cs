using System;
class Program
{
    static void Main()
    {
        string zerg = Console.ReadLine()
            .Replace("Rawr", "0")
            .Replace("Rrrr", "1")
            .Replace("Hsst", "2")
            .Replace("Ssst", "3")
            .Replace("Grrr", "4")
            .Replace("Rarr", "5")
            .Replace("Mrrr", "6")
            .Replace("Psst", "7")
            .Replace("Uaah", "8")
            .Replace("Uaha", "9")
            .Replace("Zzzz", "A")
            .Replace("Bauu", "B")
            .Replace("Djav", "C")
            .Replace("Myau", "D")
            .Replace("Gruh", "E");

        Console.WriteLine(ZergToDecimal(zerg));

    }
    static long ZergToDecimal(string zerg)
    {
        long result = 0;
        int power = zerg.Length - 1;

        for (int i = 0; i < zerg.Length; i++)
        {
            int currentDigit = 0;
            if (zerg[i] >= '0' && zerg[i] <= '9')
            {
                currentDigit = zerg[i] - '0';
            }
            else if (zerg[i] >= 'A' && zerg[i] <= 'F')
            {
                currentDigit = zerg[i] - 'A' + 10;
            }

            result += currentDigit * (long)Math.Pow(15, power);
            power--;
        }

        return result;
    }
  
}

