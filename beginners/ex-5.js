/* Write a function in JavaScript to find and return the maximum element in an array of integers. The function should take an array of integers as input and return the largest value in the array. */

function maxNum(arr) {
    let maxNum = Math.max(...arr);
    return maxNum;
}

// Example usage:
console.log(maxNum([3, 7, 1, 9, 5])); // 9
