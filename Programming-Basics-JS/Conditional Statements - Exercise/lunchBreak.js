function lunchBreak(input) {

    let nameOfSerial = (input[0]);
    let episodeDuration = Number(input[1]);
    let restDuration = Number(input[2]);

    let timeToWatch = ((5 / 8) * restDuration);
    
    if (timeToWatch >= episodeDuration) {
        console.log(`You have enough time to watch ${nameOfSerial} and left with ${Math.ceil(timeToWatch - episodeDuration)} minutes free time.`);
    } else {
        console.log(`You don't have enough time to watch ${nameOfSerial}, you need ${Math.ceil(episodeDuration - timeToWatch)} more minutes.`);
    }

}

lunchBreak(["Game of Thrones", "48", "60"]);