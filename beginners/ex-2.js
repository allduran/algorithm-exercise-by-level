/* Write a function that checks whether a given positive integer n is a prime number. If n is prime, the function should return true; otherwise, it should return false. */

function isPrime(n) {
    if (n <= 1) {
        return false; // 1 and any number less than 1 are not prime
    }
    
    if (n <= 3) {
        return true; // 2 and 3 are prime
    }
    
    if (n % 2 === 0 || n % 3 === 0) {
        return false; // Numbers divisible by 2 or 3 are not prime
    }
    
    for (let i = 5; i * i <= n; i += 6) {
        if (n % i === 0 || n % (i + 2) === 0) {
            return false; // Check for divisibility by numbers in the form of 6k ± 1
        }
    }
    
    return true;
}
