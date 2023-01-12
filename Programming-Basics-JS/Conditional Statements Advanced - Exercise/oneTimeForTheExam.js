function onTimeForExam(input) {
    let hourOfExam = Number(input[0]);
    let minutesOfExam = Number(input[1]);
    let hourOfCooming = Number(input[2]);
    let minutesOfCooming = Number(input[3]);
   
    let timeOfExam = hourOfExam * 60 + minutesOfExam;
    let timeOfCooming = hourOfCooming * 60 + minutesOfCooming;
   
    if (timeOfCooming > timeOfExam) {
      console.log(`Late`);
      if (timeOfCooming - timeOfExam < 60) {
        console.log(`${timeOfCooming - timeOfExam} minutes after the start`);
      } else if ((timeOfCooming - timeOfExam) % 60 >= 10) {
        console.log(`${Math.floor((timeOfCooming - timeOfExam) / 60)}:${(timeOfCooming - timeOfExam) % 60}  hours after the start`);
      } else if ((timeOfCooming - timeOfExam) % 60 < 10) {
        console.log(`${Math.floor((timeOfCooming - timeOfExam) / 60)}:0${(timeOfCooming - timeOfExam) % 60}  hours after the start`);
      }
    } else if (timeOfExam - timeOfCooming <= 30) {
      console.log(`On time`);
      console.log(`${timeOfExam - timeOfCooming} minutes before the start`);
    } else if (timeOfCooming === timeOfExam) {
      console.log(`On time`);
    } else if (timeOfCooming < timeOfExam) {
      console.log(`Early`);
   
      if (timeOfExam - timeOfCooming < 60) {
        console.log(`${timeOfExam - timeOfCooming} minutes before the start`);
      } else if ((timeOfExam - timeOfCooming) % 60 >= 10) {
        console.log(`${Math.floor((timeOfExam - timeOfCooming) / 60)}:${(timeOfExam - timeOfCooming) % 60}  hours before the start`);
      } else if ((timeOfExam - timeOfCooming) % 60 < 10) {
        console.log(`${Math.floor((timeOfExam - timeOfCooming) / 60)}:0${(timeOfExam - timeOfCooming) % 60}  hours before the start`);
      }
    }
  }
  onTimeForExam(["9", "5", "11", "50"]);