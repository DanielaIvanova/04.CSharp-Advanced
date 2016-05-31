using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class test
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(CatToDec).Sum();

            Console.WriteLine(DecToCat(input) + " = " + input);

        }
        static long CatToDec(string input)
        {
            long sum = 0;

            foreach (char digit in input)
            {
                sum = (digit - 'a') + sum * 23;
            }

            return sum;
        }
        static string DecToCat(long catNumber)
        {
            string result = string.Empty;

            do
            {
                char value = (char)((catNumber % 23) + 'a');
                result = value + result;
                catNumber /= 23;


            } while (catNumber != 0);
            return result;
        }

    }

}
