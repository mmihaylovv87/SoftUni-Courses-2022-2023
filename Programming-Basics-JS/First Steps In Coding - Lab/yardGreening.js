function yardGreening(input) {

    let dimensionsOfYardGreening = Number(input[0]);

    let pricePerSquareMeter = 7.61;
    let discount = 0.18;

    let totalPrice = dimensionsOfYardGreening * pricePerSquareMeter;
    let thePriceAfterDiscount = totalPrice - (totalPrice * discount);

    "The final price is: {крайна цена на услугата} lv.";

    "The discount is: {отстъпка} lv.";

    let theFinalPrice = `The final price is: ${thePriceAfterDiscount} lv.`;
    let thePriceOfDiscount = `The discount is: ${totalPrice * discount} lv.`;

    console.log(theFinalPrice);
    console.log(thePriceOfDiscount);

}

yardGreening(["550"]);