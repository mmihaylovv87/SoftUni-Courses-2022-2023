function basketballEquipment(input) {

    let taxPerYear = Number(input[0]);
    let shoes = (taxPerYear - (taxPerYear * 0.4));
    let equipment = (shoes - (shoes * 0.2));
    let ball = equipment / 4;
    let accessories = ball / 5;

    let totalMoney = taxPerYear + shoes + equipment + ball + accessories;

    console.log(totalMoney);
    
}

basketballEquipment(["25"]);