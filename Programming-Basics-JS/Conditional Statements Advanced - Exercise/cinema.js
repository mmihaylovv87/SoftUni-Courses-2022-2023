function cinema(input) {
    
    let type = input[0];
    let rows = Number(input[1]);
    let columns = Number(input[2]);

    let income = 0;

    if (type == "Premiere") {
        income = columns * rows * 12.00;
    } else if (type == "Normal") {
        income = columns * rows * 7.50;
    } else if (type == "Discount") {
        income = columns * rows * 5;
    }
    console.log(`${income.toFixed(2)} leva`);
}
cinema("Normal", "21", "13");