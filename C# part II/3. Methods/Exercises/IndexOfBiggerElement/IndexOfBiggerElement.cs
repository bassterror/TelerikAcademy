// Write a method that returns the index of the first element in array that is bigger than its neighbors,
// or -1, if there’s no such element. Use the method from the previous exercise.
using System;

namespace IndexOfBiggerElement
{
    class IndexOfBiggerElement
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

            int hasNeighbours = -1;
            for (int i = 1; i < size - 1; i++)
            {
                hasNeighbours = CheckNeighbours(i, array);
                if (hasNeighbours == 1)
                {
                    Console.WriteLine("The index of the first element that is bigger than its neighbors is {0}.", i);
                    return;
                }
            }
            Console.WriteLine(hasNeighbours);
        }

        private static int CheckNeighbours(int index, int[] array)
        {
            if (array[index] > array[index + 1] && array[index] > array[index - 1])
            {
                return 1;
            }
            else
            {
                return -1;
            }

        }
    }
}
