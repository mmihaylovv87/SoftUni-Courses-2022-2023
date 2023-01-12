function vacationBookList(input){

    let pages = Number(input[0]);
    let pagesForOneHour = Number(input[1]);
    let days = Number(input[2]);

    let finalTime = pages / pagesForOneHour;
    let hourPerDay = finalTime / days;

    console.log(hourPerDay);

}

vacationBookList(["200", "20", "4"]);