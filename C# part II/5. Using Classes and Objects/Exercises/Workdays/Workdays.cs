// Write a method that calculates the number of workdays between today and given date, passed as parameter. 
// Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
using System;

namespace Workdays
{
    class Workdays
    {
        static readonly DateTime[] holidays =
        {
            new DateTime(2013, 12, 24),
            new DateTime(2013, 12, 25),
            new DateTime(2013, 12, 26),
            new DateTime(2013, 12, 31),
            new DateTime(2014, 01, 01),
            new DateTime(2014, 01, 08)
        };

        static void Main()
        {
            Console.Write("Enter a end date in YYYY/MM/DD format: ");
            DateTime endDay = DateTime.Parse(Console.ReadLine());
            DateTime startDay = DateTime.Today;            
            int timePeriod = 0;
            timePeriod = Math.Abs((endDay - startDay).Days);
            if (startDay > endDay)
            {
                startDay = endDay;
                endDay = DateTime.Today;
            }

            int workDayCounter = 0;
            bool isHoliday = false;
            for (int i = 0; i < timePeriod; i++)
            {
                startDay = startDay.AddDays(1);
                if (startDay.DayOfWeek != DayOfWeek.Sunday && startDay.DayOfWeek != DayOfWeek.Saturday)
                {
                    for (int j = 0; j < holidays.Length; j++)
                    {
                        if (startDay == holidays[j])
                        {
                            isHoliday = true;
                            break;
                        }
                    }
                    if (!isHoliday)
                    {
                        workDayCounter++;
                    }
                    isHoliday = false;
                }
            }
            Console.WriteLine("Workdays: {0}", workDayCounter);
        }
    }
}