// Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int sum = 0;
        
        for (int i = 0; i < n; i++)           
        {
            Console.Write("Enter the next number n{0}: ", i);
            a = int.Parse(Console.ReadLine());
            sum = sum + a;              
        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}