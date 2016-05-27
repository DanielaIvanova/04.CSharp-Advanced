using System;
using System.Globalization;


class DateDifference
{
    static void Main()
    {
        Console.WriteLine("Enter the first day in format d.MM.yyyy: ");
        string firstDate = Console.ReadLine();
        Console.WriteLine("Enter the second day in format d.MM.yyyy: ");
        string secondDate = Console.ReadLine();

        var startDate= DateTime.ParseExact(firstDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(secondDate, "d.MM.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("Distance between dates: {0} days", (endDate - startDate).TotalDays);

    }
}

