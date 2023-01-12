function firstEx(input) {

    let fatCalories = Number(input[0]);
    let proteinCalories = Number(input[1]);
    let carbohydratesCalories = Number(input[2]);
    let totalCalories = Number(input[3]);
    let waterContent = Number(input[4]);

    let sumFat = ((fatCalories / 100) * totalCalories) / 9;
    let sumProtein = ((proteinCalories / 100) * totalCalories) / 4;
    let sumCarbohydrates = ((carbohydratesCalories / 100) * totalCalories) / 4;

    let foodWeight = sumFat + sumProtein + sumCarbohydrates;
    let caloriesPerOneGramFood = totalCalories / foodWeight
    let percentOfFoodCalories = 100 - waterContent;
    let oneGramOfFoodCalories = (percentOfFoodCalories / 100) * caloriesPerOneGramFood;
    console.log(oneGramOfFoodCalories.toFixed(4));
}
firstEx(["60", "25", "15", "2500", "60"]);