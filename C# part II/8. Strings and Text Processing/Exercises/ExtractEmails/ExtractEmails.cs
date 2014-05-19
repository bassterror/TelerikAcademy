// Write a program for extracting all email addresses from given text.
// All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class ExtractEmails
    {
        static void Main()
        {
            string input = "dssasdwq.sadhjdas, blabla@telerik.com edwdssdcsdc,blablabla@gmail.com asdawqqascc";
            Console.WriteLine("Emails: ");
            foreach (var item in Regex.Matches(input, @"\w+@\w+\.\w+"))
            {
                Console.WriteLine(item);
            }
        }
    }
}