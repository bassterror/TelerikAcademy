// Write a program that extracts from given XML file all the text without the tags. Example:
// <?xml version="1.0">
// <student>
//     <name>Pesho</name>
//     <age>21</age>
//     <interests count="3">
//         <interest>Games</instrest>
//         <interest>C#</instrest>
//         <interest> Java</instrest>
//     </interests>
// </student>

using System;
using System.IO;
using System.Text;

namespace ExtractXML
{
    class ExtractXML
    {
        static void Main()
        {
            using (StreamReader read = new StreamReader("input.xml"))
            {
                for (int character; (character = read.Read()) != -1; )
                {
                    if (character == '>')
                    {
                        StringBuilder text = new StringBuilder();
                        while ((character = read.Read()) != -1 && character != '<')
                        {
                            text.Append((char)character);
                        }
                        string output = text.ToString();
                        if (!String.IsNullOrWhiteSpace(output))
                        {
                            Console.WriteLine(output.Trim());
                        }
                    }
                }                
            }
        }
    }
}