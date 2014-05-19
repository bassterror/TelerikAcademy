// Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
// Example:
// <html>
//   <head><title>News</title></head>
//   <body><p><a href="http://academy.telerik.com">TelerikAcademy</a>
//     aims to provide free real-world practical
//     training for young people who want to turn into
//     skillful .NET software engineers.</p></body>
// </html>
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace HTMLExtract
{
    class HTMLExtract
    {
        static void Main()
        {
            using (StreamReader read = new StreamReader("input.html"))
            {
                for (string line; (line = read.ReadLine()) != null; )
                {
                    foreach (var word in Regex.Matches(line, @"(?<=^|>)[^><]+?(?=<|$)"))
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }
    }
}