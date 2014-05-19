//Write a program to check if in a given expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d).
// Example of incorrect expression: )(a+b)).

using System;

namespace CorrectBrackets
{
    class CorrectBrackets
    {
        private static bool Check(string input)
        {
            int brackets = 0;
            foreach (var item in input)
            {
                if (item == '(')
                {
                    brackets++;
                }
                else if (item == ')')
                {
                    brackets--;
                }
                if (brackets < 0)
                {
                    return false;
                }
            }
            if (brackets == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            Console.Write("Enter expression: ");
            string input = Console.ReadLine();
            bool output = Check(input);
            if (output)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }
        }
    }
}