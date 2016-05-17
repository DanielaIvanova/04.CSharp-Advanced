using System;
using System.Linq;
class AddingPolynomials
{
    static void Main()
    {
        Console.ReadLine();
        int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int[] sumArr = Sum(firstArr, secondArr);
        Console.WriteLine(string.Join(" ",sumArr));
    }

    static int[] Sum(int[] firstArr, int[] secondArr)
    {
        int[] sumArr = new int[firstArr.Length];
        for (int i = 0; i < firstArr.Length; i++)
        {
            sumArr[i] = firstArr[i] + secondArr[i];
        }
        
        return sumArr;
    }
}

