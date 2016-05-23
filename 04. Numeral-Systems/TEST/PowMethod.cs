using System;
class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(Pow(a, b));
      
    }


    private static long Pow(int a, int b)   //повдигане 'a' на степен 'b'
    {
        long result = 1;
        for (int i = 0; i < b; i++)
        {
            result *= a;
        }

        return result;

    }

}