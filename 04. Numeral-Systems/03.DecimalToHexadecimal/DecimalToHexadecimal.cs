using System;

class _03_DecimalToHexadecimal
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine(DecToHex(number));
    }
    static string DecToHex(long number)
    {
        string digit = "";
        while (number != 0)
        {
            long bit = number % 16;
            if (bit >= 0 && bit <= 9)
            {
                digit = bit + digit;
            }
            if (bit >= 10 && bit <= 15)
            {
                digit = (char)(bit + 'A' - 10) + digit;
            }
            number /= 16;
        }
        return digit;

        //Console.WriteLine(Convert.ToString(Int64.Parse(Console.ReadLine()),16).ToString().ToUpper());  //or only this code

    }
}

