function demo(input) {

    let firstNum = Number(input[0]);
    let secondNum = Number(input[1]); 
    let thirdNum = Number(input[2]);

    for (let i = 2; i <= firstNum; i++) {
        for (let j = 2; j <= secondNum; j++) {
            for (let k = 2; k <= thirdNum; k++) {
                if (i % 2 === 0 && j <= 7 && k % 2 === 0) {
                    if (j === 2 || j === 3 || j === 5 || j === 7) {
                        console.log(`${i} ${j} ${k}`);
                    }
                }
            }
        }
    }
}
demo(["8", "2", "8"]);