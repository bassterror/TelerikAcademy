// Write a method that return the maximal element in a portion of array of integers starting at given index. 
// Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Linq;

namespace MaximalElementInPortionOfArray
{
    class MaximalElementInPortionOfArray
    {
        static void Main()
        {
            Console.Write("Enter how much elements of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter elements:");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter index of the first element of the portion: ");
            int startIndex = int.Parse(Console.ReadLine());

            Console.WriteLine("Maximal element in the portion is {0}.", MaximalElementInPortion(array, startIndex));
            int[] ascArray = SortAscending(array);
            Console.Write("Portion sorted ascending: ");
            for (int i = 0; i < ascArray.Length; i++)
            {
                Console.Write(ascArray[i] + " ");
            }
            Console.WriteLine();
        }

        static int MaximalElementInPortion(int[] array, int startIndex)
        {
            int max = int.MinValue;
            for (int i = startIndex; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    
                }
            }
            return max;
        }

        static int[] SortAscending(int[] array)
        {
            int indexMin;
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                indexMin = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[indexMin])
                    {
                        indexMin = j;
                    }
                }
                if (indexMin != i)
                {
                    temp = array[i];
                    array[i] = array[indexMin];
                    array[indexMin] = temp;
                }
            }
            return array;
        }
    }
}