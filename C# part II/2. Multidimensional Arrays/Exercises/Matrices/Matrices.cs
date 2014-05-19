// Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
// a) 1 5  9 13  b) 1 8  9 16  c) 7 11 14 16  d) 1 12 11 10
//    2 6 10 14     2 7 10 15     4  8 12 15     2 13 16  9
//    3 7 11 15     3 6 11 14     2  5  9 13     3 14 15  8
//    4 8 12 16     4 5 12 13     1  3  6 10     4  5  6  7

using System;

class Matrix
{
    static void Main()
    {
        //Gather info from user
        Console.Write("Enter N for scale of the matrix: ");
        int n = int.Parse(Console.ReadLine());

        //Fills the a) matrix
        int[,] matrixA = new int[n, n];
        int elementA = 1;
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrixA[row, col] = elementA;
                elementA++;
            }
        }

        //Prints the a) matrix
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, 4}", matrixA[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();


        //Fills the b) matrix
        int[,] matrixB = new int[n, n];
        int elementB = 1;
        for (int col = 0; col < n; col++)
        {
            if (col % 2 != 0)
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrixB[row, col] = elementB;
                    elementB++;
                }
            }
            else
            {
                for (int row = 0; row < n; row++)
                {
                    matrixB[row, col] = elementB;
                    elementB++;
                }
            }
        }

        //Prints the b) matrix
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, 4}", matrixB[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();


        //Fills the c) matrix
        int[,] matrixC = new int[n, n];
        int elementC = 1;
        int rowC = n - 1;
        int colC = 0;
        int tempRow = n - 1;
        int tempCol = 0;
        matrixC[rowC, colC] = 1;
        while (elementC < n * n)
        {            
            if (rowC == (n - 1) && colC < (n - 1))
            {
                tempRow--;
                tempCol = 0;
                rowC = tempRow;
                colC = tempCol;
                elementC++;
                matrixC[rowC, colC] = elementC;
                while (rowC < (n - 1) && colC < (n - 1))
                {
                    rowC++;
                    colC++;
                    elementC++;
                    matrixC[rowC, colC] = elementC;
                }
            }
            if (rowC <= (n - 1) && colC == (n - 1))
            {
                tempRow = 0;
                tempCol++;
                rowC = tempRow;
                colC = tempCol;
                elementC++;
                matrixC[rowC, colC] = elementC;
                while (colC < (n - 1))
                {
                    rowC++;
                    colC++;
                    elementC++;
                    matrixC[rowC, colC] = elementC;
                }
            }
        }

        //Prints the c) matrix
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, 4}", matrixC[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();


        //Fills the d) matrix
        int[,] matrixD = new int[n, n];
        int elementD = 1;
        string direction = "down";
        int currentRow = 0;
        int currentCol = 0;
        for (int i = 1; i <= n * n; i++)
        {
            if (direction == "down" && (currentRow >= n || matrixD[currentRow, currentCol] != 0))
            {
                currentCol++;
                currentRow--;
                direction = "right";
            }
            else if (direction == "right" && (currentCol >= n || matrixD[currentRow, currentCol] != 0))
            {
                currentCol--;
                currentRow--;
                direction = "up";
            }
            else if (direction == "up" && (currentRow < 0 || matrixD[currentRow, currentCol] != 0))
	        {
                currentRow++;
		        currentCol--;
                direction = "left";
	        }
            else if (direction == "left" && (currentCol < 0 || matrixD[currentRow, currentCol] != 0))
            {
                currentRow++;
                currentCol++;
                direction = "down";
            }

            matrixD[currentRow, currentCol] = i;
            if (direction == "right")
            {
                currentCol++;
            }
            else if (direction == "up")
            {
                currentRow--;
            }
            else if (direction == "left")
            {
                currentCol--;
            }
            else if (direction == "down")
            {
                currentRow++;
            }
        }


        //Prints the d) matrix
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, 4}", matrixD[row, col]);
            }
            Console.WriteLine();
        }
    }
}