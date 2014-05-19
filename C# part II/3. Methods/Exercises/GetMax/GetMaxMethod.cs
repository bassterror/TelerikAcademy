// Write a method GetMax() with two parameters that returns the bigger of two integers.
// Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

namespace GetMax
{
    class GetMaxMethod
    {
        static int GetMax(int a, int b)
        {
            int bigger = a;
            if (b > bigger)
            {
                bigger = b;
            }
            return bigger;
        }

        static void Main()
        {
            int[] numbers = new int[3];
            Console.WriteLine("Enter your 3 numbers:");
            for (int i = 0; i < 3; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int biggest;
            biggest = GetMax(numbers[0], numbers[1]);
            biggest = GetMax(biggest, numbers[2]);
            Console.WriteLine("The biggest number is: {0}", biggest);
        }
    }
}