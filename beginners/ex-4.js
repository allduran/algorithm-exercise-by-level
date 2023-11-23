/* Write a function in JavaScript that checks if a given string is a palindrome. A palindrome is a word, phrase, or sequence of characters that reads the same backward as forward. For example, "racecar" and "level" are palindromes. Your function should return true if the input string is a palindrome and false otherwise. */

function isPalindrome(str) {
    // Remove non-alphanumeric characters and convert to lowercase
    const cleanStr = str.replace(/[^a-zA-Z0-9]/g, '').toLowerCase();
    
    // Reverse the cleaned string
    const reversedStr = cleanStr.split('').reverse().join('');
    
    // Check if the cleaned string is the same as its reverse
    return cleanStr === reversedStr;
}

// Example usage:
console.log(isPalindrome("racecar")); // true
console.log(isPalindrome("hello"));   // false
