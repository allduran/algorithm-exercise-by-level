/* Write a function in C# that calculates the factorial of a given non-negative integer n. The factorial of a number is the product of all positive integers from 1 to n. For example, the factorial of 5 (denoted as 5!) is 5 x 4 x 3 x 2 x 1 = 120. */

using System;

class Program
{
    static int Factorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }

    static void Main()
    {
        Console.WriteLine(Factorial(5)); // Example usage: Factorial of 5 is 120
    }
}
