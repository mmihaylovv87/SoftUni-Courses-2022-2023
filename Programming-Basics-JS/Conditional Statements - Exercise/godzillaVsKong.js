function godzillaVsKong(input) {
  let budget = Number(input[0]);
  let actorsCount = Number(input[1]);
  let singleOutfitPrice = Number(input[2]);

  let decorPrice = budget * 0.1;
  let totalActorsCoast = actorsCount * singleOutfitPrice;

  if (actorsCount > 150) {
    totalActorsCoast = totalActorsCoast * 0.9;
  }

  let totalSum = decorPrice + totalActorsCoast;

  if (budget >= totalSum) {
    console.log(`Action!`);
    console.log(`Wingard starts filming with ${(budget - totalSum).toFixed(2)} leva left.`);
  } else {
    console.log(`Not enough money!`);
    console.log(`Wingard needs ${(totalSum - budget).toFixed(2)} leva more.`);
  }
}

godzillaVsKong(["20000", "120", "55.5"]);