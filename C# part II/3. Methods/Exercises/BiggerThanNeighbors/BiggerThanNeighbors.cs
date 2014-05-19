// Write a method that checks if the element at given position in given array of integers
// is bigger than its two neighbors (when such exist).
using System;

namespace BiggerThanNeighbors
{
    class BiggerThanNeighbors
    {
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
            Console.Write("Enter index of the element you looking for: ");
            int index = int.Parse(Console.ReadLine());
            Neighbors(index, size, array);
        }

        static void Neighbors(int index, int size, int[]array)
        {
            if (index >= size || index < 0)
            {
                Console.WriteLine("Wrong index!");
                Main();
            }
            else
            {
                if (index == size - 1)
                {
                    Console.WriteLine("There's one neighbor on the left.");
                    Left(index, array);
                }
                else if (index == 0)
                {
                    Console.WriteLine("There's one neighbor on the right.");
                    Right(index, array);
                }
                else
                {
                    Console.WriteLine("There are two neighbors on both sides.");
                    Right(index, array);
                    Left(index, array);
                }
            }
        }

        static void Right(int index, int[] array)
        {
            if (array[index] > array[index + 1])
            {
                Console.WriteLine("Your element is bigger than the right neighbor.");
            }
            else if (array[index] < array[index + 1])
            {
                Console.WriteLine("Your element is smaller than the right neighbor.");
            }
            else
            {
                Console.WriteLine("Your element is equal to the right neighbor.");
            }
        }

        static void Left(int index, int[] array)
        {
            if (array[index] > array[index - 1])
            {
                Console.WriteLine("Your element is bigger than the left neighbor.");
            }
            else if (array[index] < array[index - 1])
            {
                Console.WriteLine("Your element is smaller than the left neighbor.");
            }
            else
            {
                Console.WriteLine("Your element is equal to the left neighbor.");
            }
        }
    }
}
