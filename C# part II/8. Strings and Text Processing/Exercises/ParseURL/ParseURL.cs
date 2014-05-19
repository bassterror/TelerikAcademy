﻿// Write a program that parses an URL address given in the format: [protocol]://[server]/[resource]
// and extracts from it the [protocol], [server] and [resource] elements.
// For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
// [protocol] = "http"
// [server] = "www.devbg.org"
// [resource] = "/forum/index.php"

using System;
using System.Text.RegularExpressions;

namespace ParseURL
{
    class ParseURL
    {
        static void Main()
        {
            string url = "http://www.devbg.org/forum/index.php";
            Console.WriteLine("URL: {0}", url);
            var parts = Regex.Match(url, "(.*)://(.*?)(/.*)").Groups;
            Console.WriteLine("[protocol] = {0}", parts[1]);
            Console.WriteLine("[server] = {0}",parts[2]);
            Console.WriteLine("[resource] = {0}",parts[3]);
        }
    }
}