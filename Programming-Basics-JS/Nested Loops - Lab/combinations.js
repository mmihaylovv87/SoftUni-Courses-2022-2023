function combinations(input) {
    
    let n = Number(input[0]);
    let validCombinationCount = 0;

    for (let x = 0; x <= n; x++) {
        for (let y = 0; y <= n; y++) {
            for (let z = 0; z <= n; z++) {
                if (x + y + z === n) {
                    validCombinationCount++;
                }
            }
        }
    }
    console.log(validCombinationCount);
}
combinations(["25"]);