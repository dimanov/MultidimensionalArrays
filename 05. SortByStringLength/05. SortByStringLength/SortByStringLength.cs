/*
 * Problem 5. Sort by string length
 * You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
 */

using System;
using System.Linq;

class SortByStringLength
{
    static void Main()
    {
        Console.Write("Please enter the size of the array: n=");
        int n = int.Parse(Console.ReadLine());
        string[] myArray = ReadArray(n);

        var sortedArray = myArray.OrderBy(x => x.Length);

        foreach(string word in sortedArray)
        {
            Console.Write("{0} ", word);
        }
        Console.WriteLine();

    }

    private static string[] ReadArray(int n)
    {
        Console.WriteLine("Please enter {0} string members of the array, separated by comma!", n);
        string[] arrParam = Console.ReadLine().Split(',').ToArray();
        return arrParam;
    }
}