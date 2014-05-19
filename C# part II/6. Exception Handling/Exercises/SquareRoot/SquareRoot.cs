// Write a program that reads an integer number and calculates and prints its square root.
// If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.
using System;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input);
                Console.WriteLine(Math.Sqrt(number));
            }
            catch (ArgumentNullException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            catch (OverflowException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}