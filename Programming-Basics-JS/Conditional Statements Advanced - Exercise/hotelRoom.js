function hotelRoom(input) {
  let mount = input[0];
  let nights = Number(input[1]);

  let studioPrice = 0;
  let apartmentPrice = 0;

  if (mount === "May" || mount === "October") {
    studioPrice = 50;
    apartmentPrice = 65;

    if (nights > 14) {
      studioPrice = studioPrice * 0.7;
      apartmentPrice = apartmentPrice * 0.9;
    } else if (nights > 7) {
      studioPrice = studioPrice * 0.95;
    }
  } else if (mount === "June" || mount === "September") {
    studioPrice = 75.2;
    apartmentPrice = 68.7;

    if (nights > 14) {
      studioPrice = studioPrice * 0.8;
      apartmentPrice = apartmentPrice * 0.9;
    }
  } else if (mount === "July" || mount === "August") {
    studioPrice = 76;
    apartmentPrice = 77;

    if (nights > 14) {
      apartmentPrice = apartmentPrice * 0.9;
    }
  }
  console.log(`Apartment: ${(apartmentPrice * nights).toFixed(2)} lv.`);
  console.log(`Studio: ${(studioPrice * nights).toFixed(2)} lv.`);
}
hotelRoom(["May", "15"]);
