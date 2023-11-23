/* Write a function in C# that checks if a given string is a palindrome. A palindrome is a word, phrase, or sequence of characters that reads the same backward as forward. For example, "racecar" and "level" are palindromes. Your function should return true if the input string is a palindrome and false otherwise. */

using System;
using System.Linq;

class Program
{
    static bool IsPalindrome(string str)
    {
        // Remove non-alphanumeric characters and convert to lowercase
        string cleanStr = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();

        // Reverse the cleaned string
        char[] charArray = cleanStr.ToCharArray();
        Array.Reverse(charArray);
        string reversedStr = new string(charArray);

        // Check if the cleaned string is the same as its reverse
        return cleanStr == reversedStr;
    }

    static void Main()
    {
        Console.WriteLine(IsPalindrome("racecar")); // true
        Console.WriteLine(IsPalindrome("hello"));   // false
    }
}
