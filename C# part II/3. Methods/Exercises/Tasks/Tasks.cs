// Write a program that can solve these tasks:
// - Reverses the digits of a number
// - Calculates the average of a sequence of integers
// - Solves a linear equation a * x + b = 0
// Create appropriate methods.
// Provide a simple text-based menu for the user to choose which task to solve.
// Validate the input data:
// - The decimal number should be non-negative
// - The sequence should not be empty
// - a should not be equal to 0

using System;
using System.Threading;
using System.Globalization;
using System.Text;

namespace Tasks
{
    class Tasks
    {
        static void PrintMenu()
        {
            Console.WriteLine("1. Reverse the digits of a non negative number.");
            Console.WriteLine("2. Calculate the avarage of a sequence of integers.");
            Console.WriteLine("3. Solve a linear equation a * x + b = 0");
            Console.Write("Choose a task: ");
        }

        static void ReadInput()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int task = int.Parse(Console.ReadLine());

            if (task == 1)
            {
                Console.Write("Enter a non-negative number: ");
                decimal number = decimal.Parse(Console.ReadLine());
                string numberToString = number.ToString();

                if (number < 0)
                {
                    Console.WriteLine("The number you have entered is negative.");
                    Main();
                }
                else
                {
                    Console.WriteLine("Result: {0}", Reverse(numberToString));
                }
            }
            else if (task == 2)
            {
                Console.Write("Enter the length of the integer sequence: ");
                int size = int.Parse(Console.ReadLine());

                if (size <= 0)
                {
                    Console.WriteLine("The length you have entered is invalid.");
                    Main();
                }
                else
                {
                    int[] array = new int[size];
                    Console.WriteLine("Enter the elements:");
                    for (int i = 0; i < size; ++i)
                    {
                        array[i] = int.Parse(Console.ReadLine());
                    }

                    int average = CalculateAverage(array);
                    Console.WriteLine("The average is: {0}", average);
                }
            }
            else
            {
                Console.WriteLine("Enter the coefficients of the equation:");
                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine());

                if (a == 0.0 && b != 0.0)
                {
                    Console.WriteLine("Wrong coefficient for a! Must be a > 0");
                    Main();
                }
                else
                {
                    double result = SolveEquation(a, b);
                    Console.WriteLine("The root x = {0}", result);
                }
            }
        }

        static string Reverse(string number)
        {
            char[] array = number.ToCharArray();
            Array.Reverse(array);
            StringBuilder reversedNumber = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                reversedNumber = reversedNumber.Append(array[i]);
            }
            return reversedNumber.ToString();
        }

        static int CalculateAverage(int[] sequence)
        {
            int sequenceLength = sequence.GetLength(0);
            int sum = 0;
            foreach (int x in sequence)
            {
                sum += x;
            }

            return sum / sequenceLength;
        }

        static double SolveEquation(double a, double b)
        {
            double result = -b / a;
            return result;
        }

        static void Main()
        {
            PrintMenu();
            ReadInput();
        }
    }
}
