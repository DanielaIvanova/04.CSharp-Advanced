using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EvenDifferences
{
    // 1.read input
    // 2.put the input numbers in array
    // 3.interate aver the array and calculate the sum
    //   3.1. find absolute difference of the current and previous
    //   3.2. if even difference, sum it
    //   3.3. make a jump - even or odd
    // 4. print the result

    static void Main()
    {
        var sequence = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

        long sum = 0;
        int i = 1;

        while (i < sequence.Length)
        {
            //3.1. find abs difference
            long absDiff = Math.Abs(sequence[i] - sequence[i - 1]);

            // if even
            if (absDiff % 2 == 0)
            {
                // sum abs difference
                sum += absDiff;
                // make even jump
                i += 2;
            }
            else //if odd
            {
                // make odd jump
                i++;
            }

        }
        Console.WriteLine(sum);
    }
}

