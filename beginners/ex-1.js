/* Find the sum of all even numbers from 1 to n. */
function sumEven(n){
    let sum = 0;
    for(let i = 1; i <= n; i++){
        if (i % 2 == 0)
        {
            sum += i;
        }
    }
    return sum;
}