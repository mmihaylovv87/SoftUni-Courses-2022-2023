function summerOutfit(input) {
    let degrees = Number(input[0]);
    let timeOfTheDay = input[1];

    let outfit = 0;
    let shoes = 0;

    if (10 <= degrees && degrees <= 18) {
        if (timeOfTheDay === "Morning") {
            outfit = "Sweatshirt";
            shoes = "Sneakers";
        } else if (timeOfTheDay === "Afternoon" || timeOfTheDay === "Evening") {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
    } else if (18 < degrees && degrees <= 24) {
        if (timeOfTheDay === "Morning" || timeOfTheDay === "Evening") {
            outfit = "Shirt";
            shoes = "Moccasins";
        } else if (timeOfTheDay === "Afternoon") {
            outfit = "T-Shirt";
            shoes = "Sandals";
        }
    } else if (25 <= degrees) {
        if (timeOfTheDay === "Morning") {
            outfit = "T-Shirt";
            shoes = "Sandals";
        } else if (timeOfTheDay === "Afternoon") {
            outfit = "Swim Suit";
            shoes = "Barefoot";
        } else if (timeOfTheDay === "Evening") {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
    }
    console.log(`It's ${degrees} degrees, get your ${outfit} and ${shoes}.`);
}
summerOutfit(["16", "Morning"]);