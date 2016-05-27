using System;
class OrderWords
{
    static void Main()
    {
        Console.WriteLine("Enter words separated by spaces: ");
        string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(words);

        foreach (var item in words)
        {
            Console.WriteLine(item);
        }


    }
}

