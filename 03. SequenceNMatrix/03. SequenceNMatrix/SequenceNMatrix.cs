/*
 * Problem 3. Sequence n matrix
 * We are given a matrix of strings of size N x M. 
 * Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
 * Write a program that finds the longest sequence of equal strings in the matrix.
 */

using System;
using System.Linq;

class SequenceNMatrix
{
    static void Main()
    {
        Console.Write("Enter the number of the rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of the columns: ");
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];
        Console.WriteLine("Enter the cells of the matrix:");
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("matrix[{0},{1}] = ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3} ", matrix[row, col]);
            }
            Console.WriteLine();
        }




        //var sortedArray = matrix.GetLongLength

        //foreach (string word in sortedArray)
        //{
        //    Console.Write("{0} ", word);
        //}
        //Console.WriteLine();

    }

    //private static string[] ReadArray(int n)
    //{
    //    Console.WriteLine("Please enter {0} string members of the array, separated by comma!", n);
    //    //int[] arrParam = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
    //    string[] arrParam = Console.ReadLine().Split(',').ToArray();
    //    return arrParam;
    //}
}