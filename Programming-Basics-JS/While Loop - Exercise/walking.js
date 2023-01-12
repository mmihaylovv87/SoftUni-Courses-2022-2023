function walking(input) {
 
    let targetSteps = 10000;
    let sum = 0;
    let index = 0;
    let command = input[index];
 
    while (command !== 'Going home') {
        let steps = Number(command);
        sum += steps;
 
        if (sum >= targetSteps) {
            console.log('Goal reached! Good job!');
            console.log(`${sum - targetSteps} steps over the goal!`);
            break;
        }
        index++;
        command = input[index];
    }
    if (command === 'Going home') {
 
        let stepsToHome = Number(input[index + 1]);
        sum += stepsToHome;
 
        if (sum >= targetSteps) {
            console.log('Goal reached! Good job!');
            console.log(`${sum - targetSteps} steps over the goal!`);
        } else {
            console.log(`${targetSteps - sum} more steps to reach goal.`);
        }
    }
}
walking(["1000", "1500", "2000", "6500"]);