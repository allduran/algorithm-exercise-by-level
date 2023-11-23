/* Write a function in C# to find and return the maximum element in an array of integers. The function should take an array of integers as input and return the largest value in the array. */

using System;
using System.Linq;

class Program
{
    static int MaxNum(int[] arr)
    {
        int maxNum = arr.Max();
        return maxNum;
    }

    static void Main()
    {
        int[] numbers = { 3, 7, 1, 9, 5 };
        Console.WriteLine(MaxNum(numbers)); // 9
    }
}
