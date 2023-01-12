function traveling(input) {
    
    let needMoney = 0;
    let spendMoney = 0;
    let sumSpendMoney = 0;
    let index = 0;
    let placeForRest = input[index];

    while (placeForRest !== `End`) {

        index++;
        needMoney = Number(input[index]);
        index++;
        spendMoney = Number(input[index]);
        sumSpendMoney = 0;
        sumSpendMoney += spendMoney;
        
        while (sumSpendMoney < needMoney) {
            index++;
            spendMoney = Number(input[index]);
            sumSpendMoney += spendMoney;
        }
        if (sumSpendMoney >= needMoney) {
            console.log(`Going to ${placeForRest}!`);
        }
        index++;
        placeForRest = input[index];

    }

}   
traveling(["Greece", "1000", "200", "200", "300", "100", "150", "240", "Spain", "1200", "300", "500", "193", "423", "End"]);