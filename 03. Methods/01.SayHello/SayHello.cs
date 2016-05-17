using System;
class SayHello
{
    static void Main()
    {
        string name = Console.ReadLine();
        PrintTheName(name);
    }
    static void PrintTheName(string name)
    {
        Console.WriteLine("Hello, {0}!", name);

    }
}

