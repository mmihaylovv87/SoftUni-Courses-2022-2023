function depositCalculator(input){

    let depositSum = Number(input[0]);
    let period = Number(input[1]);
    let percent = Number(input[2]);

    //сума = депозирана сума + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)

    let sum = depositSum + period * ((depositSum * percent / 100) / 12);

    console.log(sum);

}

depositCalculator(["200", "36", "10"])