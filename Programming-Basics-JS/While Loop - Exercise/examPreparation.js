function examPreparation(input) {

    let numberOfBadGrades = Number(input[0]);
    let index = 1;
    let exerciseName = input[index];
    let sumBadGrades = 0;
    let sumGrades = 0;
    let currentGrade = 0;

    while (exerciseName !== `Enough`) {

        index++;
        currentGrade = Number(input[index]);
        sumGrades += currentGrade;
        
        if (currentGrade <= 4) {
            sumBadGrades++;
        }
        if (sumBadGrades === numberOfBadGrades) {
            console.log(`You need a break, ${sumBadGrades} poor grades.`);
            break;
        }
        index++;
        exerciseName = input[index];
    }

    if (exerciseName === `Enough`) {
        console.log(`Average score: ${(sumGrades / ((Number(index) - 1) / 2)).toFixed(2)}`);
        console.log(`Number of problems: ${(Number(index) - 1) / 2}`);
        console.log(`Last problem: ${input[Number(index - 2)]}`);
    }
}
examPreparation(["3", "Money", "6", "Story", "4", "SpringTime", "5", "Bus", "6", "Enough"]);