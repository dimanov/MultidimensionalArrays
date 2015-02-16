/*
 * Problem 1. Fill the matrix
 * Write a program that fills and prints a matrix of size  (n, n)
 * 
 * 
 */

using System;

class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Please enter the size of the matrix \nn=");
        int matrixSize = int.Parse(Console.ReadLine());
        int[,] matrix = new int[matrixSize, matrixSize];

        // Variant A

        for (int col = 0; col < matrixSize; col++)
        {
            for (int row = 0; row < matrixSize; row++)
            {
                matrix[row, col] = col * matrixSize + (row + 1);
            }
        }
        Console.WriteLine("Variant A");
        Console.WriteLine(new string('*', 30));
        PrintMatrix(matrix);
        Console.WriteLine(new string('*', 30));
        Console.WriteLine();

        // Variant B

        for (int col = 0; col < matrixSize; col = col + 2)
        {
            for (int row = 0; row < matrixSize; row++)
            {
                matrix[row, col] = col * matrixSize + (row + 1);
            }
        }
        for (int col = 1; col < matrixSize; col = col + 2)
        {
            for (int row = matrixSize - 1; row >= 0; row--)
            {
                matrix[row, col] = col * matrixSize + (matrixSize - row );
            }
        }
        Console.WriteLine("Variant B");
        Console.WriteLine(new string('*', 30));
        PrintMatrix(matrix);
        Console.WriteLine(new string('*', 30));

    }

    private static void PrintMatrix(int [,] array)
    {
        for(int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                Console.Write("{0,3}  ", array[row,col]);
            }
            Console.WriteLine();
        }
    }
}