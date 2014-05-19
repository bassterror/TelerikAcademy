// Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
// Example: Enter the first date: 27.02.2006
//          Enter the second date: 3.03.2006
//          Distance: 4 days

using System;
using System.Globalization;

namespace DaysBetweenDates
{
    class DaysBetweenDates
    {
        static void Main()
        {
            Console.Write("Enter the first date: ");
            string firstInput = Console.ReadLine();
            Console.Write("Enter the second date: ");
            string secondInput = Console.ReadLine();
            DateTime firstDate = DateTime.ParseExact(firstInput, "d.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(secondInput, "d.MM.yyyy", CultureInfo.InvariantCulture);
            double totalDays = (secondDate - firstDate).TotalDays;
            Console.WriteLine("Distance: {0}",totalDays);
        }
    }
}