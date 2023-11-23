/* Write a function in JavaScript that calculates the factorial of a given non-negative integer n. The factorial of a number is the product of all positive integers from 1 to n. For example, the factorial of 5 (denoted as 5!) is 5 x 4 x 3 x 2 x 1 = 120. */

function factorial(n) {
    if (n === 1) {
        return 1; // Base case: the factorial of 1 is 1
    } else {
        return n * factorial(n - 1); // Recursively calculate the factorial
    }
}
