function foodDelivery(input){

    let chickenMenu = Number(input[0] * 10.35);
    let fishMenu = Number(input[1] * 12.40);
    let vegetarianMenu = Number(input[2] * 8.15);

    let totalSumOfMenu = chickenMenu + fishMenu + vegetarianMenu;
    let desert = totalSumOfMenu * 0.20;
    let delivery = 2.50;

    let totalSum = totalSumOfMenu + desert + delivery;

    console.log(totalSum);

}

foodDelivery(["8.80", "12.70", "10.40"]);