function sumOfTwoNumbers(input) {

    let a = Number(input[0]);
    let b = Number(input[1]);
    let n = Number(input[2]);

    let combinationsCounter = 0;
    let isFound = false;
    

    for (let x = a; x <= b; x++) {

        for (let y = a; y <= b; y++) {

            combinationsCounter++;

            if (x + y === n) {
                console.log(`Combination N:${combinationsCounter} (${x} + ${y} = ${n})`);
                isFound = true;
                break;
            }

        }
        if (isFound) {
            break;
        }

    }
    if (isFound === false) {
        console.log(`${combinationsCounter} combinations - neither equals ${n}`);
    }
    
}
sumOfTwoNumbers(["1", "10", "5"]);