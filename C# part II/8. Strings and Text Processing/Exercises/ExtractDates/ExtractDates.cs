// Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
// Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ExtractDates
{
    class ExtractDates
    {
        static void Main()
        {
            string input = "sddfvewdsf.oasdovcjcj@sakdcnck, 89,12,89076 01.08.2010, 89.45.2009 , 23 януари 2015";
            DateTime date;
            Console.WriteLine("Dates: ");
            foreach (Match item in Regex.Matches(input, @"\b\d{2}.\d{2}.\d{4}\b"))
            {
                if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
                }
            }
                    
        }
    }
}