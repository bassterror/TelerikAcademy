// Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
// and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
using System;
using System.Globalization;

namespace Add6Hours30Min
{
    class Add6Hours30Min
    {
        static void Main()
        {
            Console.Write("Enter date and time: ");
            string input = Console.ReadLine();
            DateTime date = DateTime.ParseExact(input, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            date = date.AddHours(6.5);
            Console.WriteLine("Edited: {0} {1}", date.ToString("dddd", new CultureInfo("bg-BG")), date);
        }
    }
}