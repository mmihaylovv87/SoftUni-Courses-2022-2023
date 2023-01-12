function shopping(input) {

    let budget = Number(input[0]);
    let videoCardsCount = Number(input[1]);
    let processorsCount = Number(input[2]);
    let ramMemoriesCount = Number(input[3]);

    let priceOfOneVideoCard = 250;

    let totalSumForVideoCards = videoCardsCount * priceOfOneVideoCard;

    let priceOfOneProcessor = totalSumForVideoCards * 0.35;
    let priceOfOneRamMemory = totalSumForVideoCards * 0.10;

    let totalSumForProcessors = processorsCount * priceOfOneProcessor;
    let totalSumForRamMemories = ramMemoriesCount * priceOfOneRamMemory;

    let totalSum = totalSumForVideoCards + totalSumForProcessors + totalSumForRamMemories;

    if (videoCardsCount > processorsCount) {
        totalSum = totalSum * 0.85;
    }

    if (budget >= totalSum) {
        console.log(`You have ${(budget - totalSum).toFixed(2)} leva left!`);
    } else {
        console.log(`Not enough money! You need ${(totalSum - budget).toFixed(2)} leva more!`);
    }

}

shopping(["920.45", "3", "1", "1"]);