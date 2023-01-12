function trekkingMania(input) {

    let groupCounter = Number(input[0]);
    let totalPeople = 0;

    let p1 = 0;
    let p2 = 0;
    let p3 = 0;
    let p4 = 0;
    let p5 = 0;

    for (let index = 1; index < input.length; index++) {

        let countOfPeopleInGroup = Number(input[index]);

        totalPeople += Number(input[index]);

        if (countOfPeopleInGroup <= 5) {
            p1 += countOfPeopleInGroup;
        } else if (countOfPeopleInGroup > 5 && countOfPeopleInGroup <= 12) {
            p2 += countOfPeopleInGroup;
        } else if (countOfPeopleInGroup >= 13 && countOfPeopleInGroup <=25) {
            p3 += countOfPeopleInGroup;
        } else if (countOfPeopleInGroup >= 26 && countOfPeopleInGroup <= 40) {
            p4 += countOfPeopleInGroup;
        } else if (countOfPeopleInGroup >= 41) {
            p5 += countOfPeopleInGroup;
        }
    }
    console.log(`${(p1 / totalPeople * 100).toFixed(2)}%`);
    console.log(`${(p2 / totalPeople * 100).toFixed(2)}%`);
    console.log(`${(p3 / totalPeople * 100).toFixed(2)}%`);
    console.log(`${(p4 / totalPeople * 100).toFixed(2)}%`);
    console.log(`${(p5 / totalPeople * 100).toFixed(2)}%`);
}

trekkingMania(["10", "10", "5", "1", "100", "12", "26", "17", "37", "40", "78"]);