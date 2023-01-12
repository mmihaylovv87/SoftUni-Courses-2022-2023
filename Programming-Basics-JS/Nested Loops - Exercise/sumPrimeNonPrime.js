function equalSumsEvenOddPosition(input) {

    let index = 0;
    let command = input[index];
    index++;
 
    let primeNumber = 0;
    let nonPrimeNumber = 0;
 
    while(command !== "stop"){
        let num = Number(command);
 
        if (num < 0){
            console.log("Number is negative.");
            command = input[index];
            index++;
            continue;
        }
        if (num === 1){
            primeNumber += num;
            command = input[index];
            index++;
            continue;
        }
        let isPrime = true;
 
        for(let i = 2; i < num; i++){
 
            if(num % i === 0){
                isPrime = false;
                break;
            }
        }
        if(isPrime){
            primeNumber += num;
        } else {
            nonPrimeNumber += num
        }
        command = input[index];
        index++
    }
    console.log(`Sum of all prime numbers is: ${primeNumber}`)
    console.log(`Sum of all non prime numbers is: ${nonPrimeNumber}`)
}
equalSumsEvenOddPosition(["30", "83", "33", "-1", "20", "stop"]);