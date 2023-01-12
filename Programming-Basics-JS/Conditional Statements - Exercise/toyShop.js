function toyShop(input) {

    let tripPrice = Number(input[0]);
    let puzzles = Number(input[1]);
    let dolls = Number(input[2]);
    let bears = Number(input[3]);
    let minions = Number(input[4]);
    let trucks = Number(input[5]);

    let puzzlesTotal = puzzles * 2.60;
    let dollsTotal = dolls * 3;
    let bearsTotal = bears * 4.10;
    let minionsTotal = minions * 8.20;
    let trucksTotal = trucks * 2;

    let totalSum = puzzlesTotal + dollsTotal + bearsTotal + minionsTotal + trucksTotal;
    let toysCount = puzzles + dolls + bears + minions + trucks;

    if (toysCount >= 50) {
        totalSum = totalSum * 0.75;
    }

    totalSum = totalSum * 0.90;

    if (totalSum >= tripPrice) {
        console.log(`Yes! ${(totalSum - tripPrice).toFixed(2)} lv left.`);
    } else {
        console.log(`Not enough money! ${(tripPrice - totalSum).toFixed(2)} lv needed.`);
    }
}

toyShop(["40.8", "20", "25", "30", "50", "10"]);