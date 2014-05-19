//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
// Use variable number of arguments.

using System;

namespace SetOfIntegers
{
    class SetOfIntegers
    {
        static int FindMax(params int[] arr)
        {
            int biggestNum = arr[0];
            int length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                if (length > 0)
                {
                    if (arr[i] > biggestNum)
                    {
                        biggestNum = arr[i];
                    }
                }
                else
                {
                    return 0;
                }
            }
            return biggestNum;
        }

        static int FindMin(params int[] arr)
        {
            int smallest = arr[0];
            int length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                if (length > 0)
                {
                    if (arr[i] < smallest)
                    {
                        smallest = arr[i];
                    }
                }
                else
                {
                    return 0;
                }
            }
            return smallest;
        }

        static decimal FindAvg(params int[] arr)
        {
            decimal counter = 0;
            decimal sum = 0;
            decimal sumAvg = 0;
            foreach (var number in arr)
            {
                sum = sum + number;
                counter++;
            }
            sumAvg = sum / counter;
            return sumAvg;
        }

        static int FindSum(params int[] arr)
        {
            int sum = 0;
            foreach (var number in arr)
            {
                sum += number;
            }
            return sum;
        }
        static int FindProduct(params int[] arr)
        {
            int product = 1;
            foreach (var number in arr)
            {
                product *= number;
            }
            return product;
        }
        static void Main()
        {
            Console.Write("Enter size of the set: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter elements of the set:");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Min={0}", FindMin(array));
            Console.WriteLine("Max={0}", FindMax(array));
            Console.WriteLine("Avg={0}", FindAvg(array));
            Console.WriteLine("Sum={0}", FindSum(array));
            Console.WriteLine("Product={0}", FindProduct(array));
            Console.WriteLine();
        }
    }
}
