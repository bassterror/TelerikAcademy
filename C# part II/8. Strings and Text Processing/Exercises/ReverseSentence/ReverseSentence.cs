// Write a program that reverses the words in given sentence. Example:
// C# is not C++, not PHP and not Delphi!
// Delphi not and PHP, not C++ not is C#!

using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseSentence
{
    class ReverseSentence
    {
        static void Main()
        {
            string input = "C# is not C++, not PHP and not Delphi!";
            char[] nonSigns = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                                '+', '#', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
                                'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9'};            
            string[] words = input.Split(new char[] { ',', '!', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] signs = input.Split(nonSigns, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            StringBuilder strWordsReversed = new StringBuilder();
            for (int i = 0; i < signs.Length; i++)
            {
                strWordsReversed.Append(words[i]);
                strWordsReversed.Append(signs[i]);
            }
            Console.WriteLine(strWordsReversed.ToString());
        }
    }
}