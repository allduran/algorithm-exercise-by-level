/* Write a function that checks whether a given positive integer n is a prime number. If n is prime, the function should return true; otherwise, it should return false. */

using System;

class Program
{
    static bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }

        if (n <= 3)
        {
            return true;
        }

        if (n % 2 == 0 || n % 3 == 0)
        {
            return false;
        }

        for (int i = 5; i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0)
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        Console.WriteLine(IsPrime(11)); // Example usage: 11 is a prime number
    }
}
