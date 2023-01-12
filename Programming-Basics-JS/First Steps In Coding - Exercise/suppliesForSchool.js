function suppliesForSchool(input) {

    let pens = Number(input[0]);
    let markers = Number(input[1]);
    let liters = Number(input[2]);
    let discount = Number(input[3]);

    let moneyForPens = pens * 5.80;
    let moneyForMarkers = markers * 7.20;
    let moneyForPreparation = liters * 1.20;

    let totalMoney = moneyForMarkers + moneyForPens + moneyForPreparation;
    let moneyAfterDiscount = totalMoney - (totalMoney * (discount / 100));
    
    console.log(moneyAfterDiscount);

}

suppliesForSchool(["9", "7", "12", "20"]);