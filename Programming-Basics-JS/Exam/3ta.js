function demo(input) {

    let numberOfPeople = Number(input[0]);
    let season = input[1];

    let sumForAllPeople = 0;


    switch(season) {
        case "spring":
            if (numberOfPeople <= 5) {
                sumForAllPeople = numberOfPeople * 50;
            } else {
                sumForAllPeople = numberOfPeople * 48;
            }
            break;
        case "summer":
            if (numberOfPeople <= 5) {
                sumForAllPeople = numberOfPeople * 48.50;
            } else {
                sumForAllPeople = numberOfPeople * 45;
            }
            sumForAllPeople = sumForAllPeople * 0.85;
            break;
        case "autumn":
            if (numberOfPeople <= 5) {
                sumForAllPeople = numberOfPeople * 60;
            } else {
                sumForAllPeople = numberOfPeople * 49.50;
            }
            break;
        case "winter":
            if (numberOfPeople <= 5) {
                sumForAllPeople = numberOfPeople * 86;
            } else {
                sumForAllPeople = numberOfPeople * 85;
            }
            sumForAllPeople = sumForAllPeople * 1.08;
            break;

    }
    console.log(`${sumForAllPeople.toFixed(2)} leva.`);
}
demo(["10", "summer"]);