/* Find the sum of all even numbers from 1 to n. */

using System;

class Program
{
    static int SumEven(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }

    static void Main()
    {
        Console.WriteLine(SumEven(10)); // Example usage: Sum of even numbers from 1 to 10 is 30
    }
}
