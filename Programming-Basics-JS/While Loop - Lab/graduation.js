function graduation(input) {

    let index = 0;
    let name = input[index];
    index++;

    let isExcluded = false; 
    let sumGrade = 0;
    let badGrade = 0;
    let counter = 1;

    while (counter <= 12) {
        let tempGrade = Number(input[index]);
        index++;

        if (tempGrade < 4) {
            badGrade++;
            if (badGrade > 1) {
                isExcluded = true;
                console.log(`${name} has been excluded at ${counter} grade`);
                break; 
            }
            continue;
        } 
        sumGrade += tempGrade;
        counter++;
    }
    if (!isExcluded) {
        let avgGrade = sumGrade / 12;
        console.log(`${name} graduated. Average grade: ${avgGrade.toFixed(2)}`);
    }
}
graduation(["Mimi", "5", "6", "5", "6", "5", "6", "6", "2", "3"]);