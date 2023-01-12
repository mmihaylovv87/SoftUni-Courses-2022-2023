function demo(input) {

    let daysOff = Number(input[0]);
    let foodLeft = Number(input[1]);
    let firstDeerFoodPerDay = Number(input[2]);
    let SecondDeerFoodPerDay = Number(input[3]);
    let ThirdDeerFoodPerDay = Number(input[4]);

    let needFood = daysOff * (firstDeerFoodPerDay + SecondDeerFoodPerDay + ThirdDeerFoodPerDay);

    if (needFood <= foodLeft) {
        console.log(`${Math.floor(foodLeft - needFood)} kilos of food left.`);
    } else {
        console.log(`${Math.ceil(needFood - foodLeft)} more kilos of food are needed.`);
    }


}
demo(["2", "10", "1", "1", "2"]);
