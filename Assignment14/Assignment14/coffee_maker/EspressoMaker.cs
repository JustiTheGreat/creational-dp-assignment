﻿using Assignment14.coffee;

namespace Assignment14.coffee_maker
{
    public class EspressoMaker : CoffeeMaker
    {
        public override void StartCoffeeMakingProcess()
        {
            if (CoffeeInMaking is not null)
                Console.WriteLine("Last coffee order was discarded!");

            CoffeeInMaking = new Espresso();
        }
    }
}
