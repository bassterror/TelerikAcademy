// Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;

class BinarySearch
{
    static void Main()
    {
        //Gathers info & sorts the array
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);

        //Serches the number & Output
        int number;
        if (array[0] > k)
        {
            Console.WriteLine("There's no such number!");
        }
        else
        {
            int element = Array.BinarySearch(array, k);
            if (element >= 0)
            {
                number = array[element];
            }
            else
            {
                number = array[~element - 1];
                Console.WriteLine("Result: {0}", number);
            }
        }
    }
}