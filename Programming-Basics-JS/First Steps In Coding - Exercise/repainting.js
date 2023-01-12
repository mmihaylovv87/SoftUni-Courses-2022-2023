function repainting(input) {
    let nailon = Number(input[0]);
    let paint = Number(input[1]);
    let thinner = Number(input[2]);
    let hours = Number(input[3]);

    let totalForNailon = (nailon + 2) * 1.50;
    let totalForPaint = (paint * 1.1) * 14.50;
    let totalForThinner = thinner * 5 ;
    let bagPrice = 0.40;

    let totalForMaterials = totalForNailon + totalForPaint + totalForThinner + bagPrice;
    let totalForWorkers = (totalForMaterials * 0.30) * hours; 
    let totalMoney = totalForMaterials + totalForWorkers;

    console.log(totalMoney);
}

repainting(["5.50", "4.90", "6.70", "10"]);