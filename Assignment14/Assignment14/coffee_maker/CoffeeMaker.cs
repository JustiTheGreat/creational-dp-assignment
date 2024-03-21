using Assignment14.coffee;

namespace Assignment14.coffee_maker
{
    public abstract class CoffeeMaker
    {
        protected Coffee? CoffeeInMaking = null;

        public abstract void StartCoffeeMakingProcess();

        public void GetCoffee()
        {
            if (CoffeeInMaking is null)
                throw new NullReferenceException("There isn't a coffee in making to obtain!");

            CoffeeInMaking.Print();
        }

        public void AddExtraMilk()
        {
            if (CoffeeInMaking is null)
                throw new NullReferenceException("There isn't a coffee in making to add extra milk to!");

            CoffeeInMaking.AddExtraIngredient(CoffeeIngredient.MILK);
        }

        public void AddExtraSoyMilk()
        {
            if (CoffeeInMaking is null)
                throw new NullReferenceException("There isn't a coffee in making to add extra soy milk to!");

            CoffeeInMaking.AddExtraIngredient(CoffeeIngredient.SOY_MILK);
        }

        public void AddExtraSugar()
        {
            if (CoffeeInMaking is null)
                throw new NullReferenceException("There isn't a coffee in making to add extra sugar to!");

            CoffeeInMaking.AddExtraIngredient(CoffeeIngredient.SUGAR);
        }
    }
}
