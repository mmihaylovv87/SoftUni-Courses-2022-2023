function petShop(input) {

    let dogFood = Number(input[0] * 2.50);
    let catFood = Number(input[1] * 4);

    let result = `${dogFood + catFood} lv.`;

    console.log(result);

}

petShop(["5","4"]);