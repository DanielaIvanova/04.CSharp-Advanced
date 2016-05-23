using System;
class TriangleSurfaceBySideAndAltitude
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double ha = double.Parse(Console.ReadLine());

        double area = a * ha / 2;

        Console.WriteLine("{0:F2}",area);
       
    }
}

