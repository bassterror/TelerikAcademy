﻿// Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

namespace RandomValues
{
    class RandomValues
    {
        static void Main()
        {
            Random number = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(number.Next(100, 201));
            }
        }
    }
}