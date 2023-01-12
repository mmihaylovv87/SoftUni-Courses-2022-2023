function worldSwimmingRecord(input) {

    let worldRecordInSeconds = Number(input[0]);
    let distanceInMeters = Number(input[1]);
    let timeForMeter = Number(input[2]);

    let totalSeconds = distanceInMeters * timeForMeter;
    let delay = Math.floor(distanceInMeters / 15) * 12.5;

    let finalTime = totalSeconds + delay;

    if (finalTime < worldRecordInSeconds) {
        console.log(`Yes, he succeeded! The new world record is ${finalTime.toFixed(2)} seconds.`);
    } else {
        console.log(`No, he failed! He was ${(finalTime - worldRecordInSeconds).toFixed(2)} seconds slower.`)
    }
}

worldSwimmingRecord(["10464", "1500", "20"]);