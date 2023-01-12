function coins(input) {
 
    let change = Number(input[0]);
    let inCoins = Math.floor(change * 100);
    let coinsCounter = 0;
 
    while (inCoins > 0) {
        if (inCoins >= 200) {
            inCoins -= 200;
            coinsCounter++;
        } else if (inCoins >= 100) {
            inCoins -= 100;
            coinsCounter++;
        } else if (inCoins >= 50) {
            inCoins -= 50;
            coinsCounter++;
        } else if (inCoins >= 20) {
            inCoins -= 20;
            coinsCounter++;
        } else if (inCoins >= 10) {
            inCoins -= 10;
            coinsCounter++;
        } else if (inCoins >= 5) {
            inCoins -= 5;
            coinsCounter++;
        } else if (inCoins >= 2) {
            inCoins -= 2;
            coinsCounter++;
        } else if (inCoins >= 1) {
            inCoins -= 1;
            coinsCounter++;
        }
    }
    console.log(coinsCounter);
}
coins(["1.23"]);