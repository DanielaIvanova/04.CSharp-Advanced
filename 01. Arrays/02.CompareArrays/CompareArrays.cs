//Write a program that reads two integer arrays of size N from the console and compares them element by element.

using System;
using System.Linq;

class CompareArrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] firstArr = new int[n];
        int[] secondArr = new int[n];
        for (int i = 0; i < firstArr.Length; i++)
        {
            firstArr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < secondArr.Length; i++)
        {
            secondArr[i] = int.Parse(Console.ReadLine());
        }


        if (firstArr.SequenceEqual(secondArr))//compare two arrays
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }

        //bool isEqual = true;                    // second way
        //for (int i = 0; i < n; i++)
        //{
        //    if (firstArr[i] == secondArr[i])
        //    {
        //        isEqual = true;
        //    }
        //    else
        //    {
        //        isEqual = false;
        //        break;
        //    }
        //}
        //Console.WriteLine(isEqual ? "Equal" : "Not equal");


    }
}

