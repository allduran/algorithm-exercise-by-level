/* Write a function in JavaScript that counts the occurrences of each character in a given string and returns the results as an object. The object should have characters as keys and their respective counts as values. */

using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<char, int> CountOccurrences(string str)
    {
        Dictionary<char, int> counts = new Dictionary<char, int>();

        foreach (char ch in str)
        {
            if (counts.ContainsKey(ch))
            {
                counts[ch]++;
            }
            else
            {
                counts[ch] = 1;
            }
        }

        return counts;
    }

    static void Main()
    {
        string input = "hello";
        Dictionary<char, int> result = CountOccurrences(input);

        foreach (var entry in result)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}
