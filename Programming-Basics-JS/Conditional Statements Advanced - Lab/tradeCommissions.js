function tradeCommissions(input) {

    let town = input[0];
    let sells = Number(input[1]);

    let commissions = 0;

    if (town === "Sofia") {
        if (0 <= sells && sells <= 500) {
            console.log(commissions = (sells * 0.05).toFixed(2));
        } else if (500 < sells && sells <= 1000) {
            console.log(commissions = (sells * 0.07).toFixed(2));
        } else if (1000 < sells && sells <= 10000) {
            console.log(commissions = (sells * 0.08).toFixed(2));
        } else if (10000 < sells) { 
            console.log(commissions = (sells * 0.12).toFixed(2));
        } else {
            console.log("error");
        }
    } else if (town === "Varna") {
        if (0 <= sells && sells <= 500) {
            console.log(commissions = (sells * 0.045).toFixed(2));
        } else if (500 < sells && sells <= 1000) {
            console.log(commissions = (sells * 0.075).toFixed(2));
        } else if (1000 < sells && sells <= 10000) {
            console.log(commissions = (sells * 0.10).toFixed(2));
        } else if (10000 < sells) {
            console.log(commissions = (sells * 0.13).toFixed(2));
        } else {
            console.log("error");
        }
    } else if (town === "Plovdiv") {
        if (0 <= sells && sells <= 500) {
            console.log(commissions = (sells * 0.055).toFixed(2));
        } else if (500 < sells && sells <= 1000) {
            console.log(commissions = (sells * 0.08).toFixed(2));
        } else if (1000 < sells && sells <= 10000) {
            console.log(commissions = (sells * 0.12).toFixed(2));
        } else if (10000 < sells) {
            console.log(commissions = (sells * 0.145).toFixed(2));
        } else {
            console.log("error");
        }
    } else { 
        console.log("error");
    }
        
    

}

tradeCommissions(["Plovdiv", "-20"]);