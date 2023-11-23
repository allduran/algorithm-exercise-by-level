/* Write a function in JavaScript that counts the occurrences of each character in a given string and returns the results as an object. The object should have characters as keys and their respective counts as values. */

function countOccurrences(str) {
    const counts = {};
    
    for (const char of str) {
        if (counts[char] === undefined) {
            counts[char] = 1;
        } else {
            counts[char]++;
        }
    }

    for (const char in counts) {
        console.log(`${char}: ${counts[char]}`);
    }
}

// Example usage:
countOccurrences("hello");