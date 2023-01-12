function demo(input) {

    let numberOfPeople = Number(input[0]);
    let index = 1;
    let currentGrade = Number(input[index]);

    let sumOfGradesFrom2To3 = 0;
    let sumOfGradesFrom3To4 = 0;
    let sumOfGradesFrom4To5 = 0;
    let sumOfGradesFrom5To6 = 0;

    let counter2To3 = 0;
    let counter3To4 = 0;
    let counter4To5 = 0;
    let counter5To6 = 0;

    for (let i = 1; i <= numberOfPeople; i++) {
        if (currentGrade >= 5) {
            counter5To6++;
            sumOfGradesFrom5To6 += currentGrade;
        } else if (currentGrade >= 4 && currentGrade < 5) {
            counter4To5++;
            sumOfGradesFrom4To5 += currentGrade;
        } else if (currentGrade >= 3 && currentGrade < 4) {
            counter3To4++;
            sumOfGradesFrom3To4 += currentGrade;
        } else if (currentGrade >= 2 && currentGrade < 3) {
            counter2To3++;
            sumOfGradesFrom2To3 += currentGrade;
        }
        index++;
        currentGrade = Number(input[index]);
    }
    console.log(`Top students: ${((counter5To6 / numberOfPeople) * 100).toFixed(2)}%`);
    console.log(`Between 4.00 and 4.99: ${((counter4To5 / numberOfPeople) * 100).toFixed(2)}%`);
    console.log(`Between 3.00 and 3.99: ${((counter3To4 / numberOfPeople) * 100).toFixed(2)}%`);
    console.log(`Fail: ${((counter2To3 / numberOfPeople) * 100).toFixed(2)}%`);
    console.log(`Average: ${((sumOfGradesFrom2To3 + sumOfGradesFrom3To4 + sumOfGradesFrom4To5 + sumOfGradesFrom5To6) / numberOfPeople).toFixed(2)}`);
}
demo(["10", "3.00", "2.99", "5.68", "3.01", "4", "4", "6.00", "4.50", "2.44", "5"]);