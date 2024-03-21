using Assignment14.coffee_maker;

CoffeeMaker cappuccinoMaker = new CappuccinoMaker();
CoffeeMaker espressoMaker = new EspressoMaker();
CoffeeMaker flatWhiteMaker = new FlatWhiteMaker();

cappuccinoMaker.StartCoffeeMakingProcess();
cappuccinoMaker.AddExtraSugar();
cappuccinoMaker.AddExtraSugar();
cappuccinoMaker.GetCoffee();

espressoMaker.StartCoffeeMakingProcess();
espressoMaker.AddExtraSoyMilk();
espressoMaker.AddExtraSugar();
espressoMaker.GetCoffee();

flatWhiteMaker.StartCoffeeMakingProcess();
flatWhiteMaker.AddExtraSugar();
flatWhiteMaker.GetCoffee();

