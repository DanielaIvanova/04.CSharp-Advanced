using System;
using System.Linq;

class IncreasingAbsoluteDifferences
{
    // 1. read input
    // 2. for every sequence do the following:
    // 2.1. calcuate abs difference for each number of the sequences.
    // 2.2. check if the abs differences sequence is increasing
    // 3. print the result. This is seq[i-1]<=seq[i] and is increasing
    // 3.1. True - if the sequence is increasing
    // 3.2. False - if the sequence is not
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            var sequence = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            bool isIncreasing = true;

            for (int j = 2; j < sequence.Length; j++)
            {
                var lastAbsDiff = Math.Abs(sequence[j - 2] - sequence[j - 1]);
                var currentAbsDiff = Math.Abs(sequence[j - 1] - sequence[j]);

                if (lastAbsDiff > currentAbsDiff || currentAbsDiff - lastAbsDiff > 1)
                {
                    isIncreasing = false;
                    break;
                }

            }
            Console.WriteLine(isIncreasing);
        }
    }

}
