function fishTank(input) {
    let length = Number(input[0]);
    let width = Number(input[1]);
    let high = Number(input[2]);
    let percent = Number(input[3]);

    let volume = length * width * high;
    let volumeInLiters = volume / 1000;

    let finalResult = volumeInLiters * (1 - (percent / 100));
    console.log(finalResult);
}

fishTank(["12", "10", "15", "7"]);