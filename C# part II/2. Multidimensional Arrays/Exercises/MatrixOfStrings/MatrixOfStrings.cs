// We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements 
// located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. 
// Example:   ha  fifi ho hi                    s qq s
//            fo    ha hi xx ---> ha, ha, ha   pp pp s  ---> s, s, s 
//            xxx   ho ha xx                   pp qq s


using System;

class MatrixOfStrings
{
    static void Main()
    {
        {
            //Gathers info
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter M: ");
            int m = int.Parse(Console.ReadLine()); 
            string[,] matrix = new string[n, m];
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = Console.ReadLine();
                }
            }
            Console.WriteLine();

            //Prints the matrix
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write("{0, 5}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
 
            //Serches for the longest sequence
            const int vSeq = 0;
            const int hSeq = 1;
            const int rDiagSeq = 2;
            const int lDiagSeq = 3;             
            int maxLength = 0;
            int bestRow = 0, bestCol = 0;
            int[, ,] workMatrix = new int[n, m, 4];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    for (int k = 0; k < 4; ++k)
                    {
                        workMatrix[i, j, k] = 1;
                    }
 
                    if (i > 0 && matrix[i, j].Equals(matrix[i - 1, j]))
                    {
                        workMatrix[i, j, vSeq] = workMatrix[i - 1, j, vSeq] + 1;
                    }
                    if (j > 0 && matrix[i, j].Equals(matrix[i, j - 1]))
                    {
                        workMatrix[i, j, hSeq] = workMatrix[i, j - 1, hSeq] + 1;
                    }
                    if (i > 0 && j > 0 && matrix[i, j].Equals(matrix[i - 1, j - 1]))
                    {
                        workMatrix[i, j, rDiagSeq] = workMatrix[i - 1, j - 1, rDiagSeq] + 1;
                    }
                    if (i > 0 && j < n - 1 && matrix[i, j].Equals(matrix[i - 1, j + 1]))
                    {
                        workMatrix[i, j, lDiagSeq] = workMatrix[i - 1, j + 1, lDiagSeq] + 1;
                    }
 
                    for (int k = 0; k < 4; ++k)
                    {
                        if (workMatrix[i, j, k] > maxLength)
                        {
                            maxLength = workMatrix[i, j, k];
                            bestRow = i;
                            bestCol = j;
                        }
                    }
                }
            }

            //Output
            for (int i = 0; i < maxLength; i++)
            {
                Console.Write(matrix[bestRow, bestCol] + ", ");
            }
            Console.WriteLine();
        }
    }
}