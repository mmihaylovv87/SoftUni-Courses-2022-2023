function multiplicationTable(input) {
    
    let inputNumber = Number(input[0]);

    for (let i = 1; i <= 10; i++) {
        console.log(`${i} * ${inputNumber} = ${inputNumber * i}`);
    }
}
multiplicationTable(["5"]);