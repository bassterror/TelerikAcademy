// Write a program that reads a rectangular matrix of size NxM and finds in it the square 3x3 that has maximal sum of its elements.

using System;

class RectengularMatrix
{
    static void Main()
    {
        //Gathers info
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter M: ");
        int m = int.Parse(Console.ReadLine());
        if (n < 3 && m < 3)
        {
            Console.WriteLine("N & M must be greater than 3!");
            Main();
        }
        else
        {
            //Fills the matrix with values from the user
            int[,] matrix = new int[n, m];
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            //Prints the matrix
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write("{0, 3}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Serches for the maximal sum
            int maxSum = int.MinValue;
            int tempSum = 0;
            int bestRow = 0;
            int bestCol = 0;
            for (int row = 0; row < n - 2; row++)
            {
                for (int col = 0; col < m - 2; col++)
                {
                    tempSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + 
                        matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                        bestRow = row;
                        bestCol = col;
                    }
                }                
            }

            //Output
            Console.WriteLine("{0,3} {1,3} {2,3}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
            Console.WriteLine("{0,3} {1,3} {2,3}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
            Console.WriteLine("{0,3} {1,3} {2,3}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
            Console.WriteLine();
            Console.WriteLine("Maximal sum: {0}", maxSum);
        }        
    }
}