// Write a program that allocates array of 20 integers and initializes each element
// by its index multiplied by 5. Print the obtained array on the console.

using System;

namespace AllocateAndInitializeArray
{
    class AllocateAndInitializeArray
    {
        static void Main()
        {
            //Allocates and initializes the array
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
            }
            
            //Print array
            Console.WriteLine("Allocated array:");
            Console.WriteLine(new string('-', 57));
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
