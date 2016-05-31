using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangeLandNumbers_test
{
    class StrangeLandNumbers
    {
        static void Main()
        {/*
            0   f
            1   bIN
            2   oBJEC
            3   mNTRAVL
            4   lPVKNQ
            5   pNWE
            6   hT
            */


            var strangeNumber = Console.ReadLine()
                .Replace("f", "0")
                .Replace("bIN", "1")
                .Replace("oBJEC", "2")
                .Replace("mNTRAVL", "3")
                .Replace("lPVKNQ", "4")
                .Replace("pNWE", "5")
                .Replace("hT", "6");

            Console.WriteLine(StrangeToDec(strangeNumber));


        }
        static ulong StrangeToDec(string strangeNumber)
        {
            ulong sum = 0;

            foreach (var item in strangeNumber)
            {
                sum = (ulong)(item - '0') + sum * 7;

            }
            return sum;
        }
        //int sum = 0;

        //    foreach (char bit in binary)
        //    {
        //        sum = (bit - '0') + sum* 2;
        //    }

        //    return sum;
    }
}
