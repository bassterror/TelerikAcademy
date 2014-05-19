// Write a method that counts how many times given number appears in given array.
// Write a test program to check if the method is working correctly.
using System;

namespace RepeatNumberCount
{
    class RepeatNumberCount
    {
        public static int NumberToCount;
        public static int Counter;

        public static void Count(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == NumberToCount)
                {
                    Counter++;
                }
            }
        }
        
        static void Main()
        {
            Console.Write("Enter size of the array: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of the array:");
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
			{
			    array[i] = int.Parse(Console.ReadLine());
			}
            
            Console.Write("Which integer do you want to count: ");
            NumberToCount = int.Parse(Console.ReadLine());
            Count(array);
            Console.WriteLine("It repeats {0} times.", Counter);
        }
    }
}
