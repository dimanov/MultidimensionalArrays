/*
 * Problem 4. Binary search
 * Write a program, that reads from the console an array of  N  integers and an integer  K , 
 * sorts the array and using the method  Array.BinSearch()  finds the largest number in the array which is ≤  K . 
 */

using System;
using System.Linq;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Please enter the size of the array: n=");
        int n = int.Parse(Console.ReadLine());
        int[] myArray = ReadArray(n);
        //int[] myArray = { 0, 2, 4, 0, 9, 5 };

        Console.Write("Please enter an integer (K>0): k=");
        int k = int.Parse(Console.ReadLine());

        Array.Sort(myArray);
        int min = myArray.Min();
        int index = Array.BinarySearch(myArray, k);

        while (index < 0)
        {
            k--;
            index = Array.BinarySearch(myArray, k);
        }
        Console.WriteLine("The largest number in the array which is <=  K is: {0}", myArray[index]);
    }

    private static int[] ReadArray(int n)
    {
        Console.WriteLine("Please enter {0} members of the array, separated by comma!", n);

        int[] arrParam = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

        return arrParam;
    }
}