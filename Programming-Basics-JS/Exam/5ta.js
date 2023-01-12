function demo(input) {
    
    let packagesForSea = Number(input[0]);
    let packagesForMountain = Number(input[1]);
    
    let index = 2;
    let command = input[index];
    
    let seaPrice = 680;
    let mountainPrice = 499;
    let totalSea = 0;
    let totalMountain = 0;

    while (command !== "Stop") {
        if (command === "sea") {
            packagesForSea--;
            totalSea += seaPrice;
            if (packagesForSea < 0) {
                totalSea -= seaPrice;
            }
        } else if (command === "mountain") {
            packagesForMountain--;
            totalMountain += mountainPrice;
            if (packagesForMountain < 0) {
                totalMountain -= mountainPrice;
            }
        }
        if (packagesForMountain <= 0 && packagesForSea <= 0) {
            console.log(`Good job! Everything is sold.`);
            break;
        }
        index++;
        command = input[index];  
    }
    console.log(`Profit: ${totalMountain + totalSea} leva.`);
}
demo(["2", "2", "sea", "mountain", "sea", "sea", "mountain"]);