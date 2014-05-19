// Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an
// area of size 2x2 with a maximal sum of its elements. The first line in the input file contains the size of matrix N.
// Each of the next N lines contain N numbers separated by space. The output should be a single number in a separate text file.
// Example:    2 3 3 4
//             0 2 3 4
//             3 7 1 2
//             4 3 3 2

using System;
using System.IO;

namespace MaxSumInMatrix
{
    class MaxSumInMatrix
    {
        static void Main()
        {
            using (StreamReader read = new StreamReader("input.txt"))
            {
                int n = int.Parse(read.ReadLine());
                int[,] matrix = new int[n, n];
                string line;
                int matrixLine = 0;
                while ((line = read.ReadLine()) != null)
                {
                    string[] elements = line.Split(' ');
                    for (int i = 0; i < elements.Length; i++)
                    {
                        matrix[matrixLine, i] = int.Parse(elements[i]);
                    }
                    matrixLine++;
                }

                int bestSum = int.MinValue;
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                    {
                        int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                        if (sum > bestSum)
                        {
                            bestSum = sum;
                        }
                    }
                }

                using (StreamWriter write = new StreamWriter("output.txt"))
                {
                    write.WriteLine(bestSum);
                }
            }
            Console.WriteLine("Done!");
        }
    }
}