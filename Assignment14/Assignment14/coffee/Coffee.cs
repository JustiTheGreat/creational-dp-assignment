namespace Assignment14.coffee
{
    public abstract class Coffee
    {
        protected readonly List<CoffeeIngredient> Ingredients = [];

        public void AddExtraIngredient(CoffeeIngredient coffeeIngredient)
        {
            Ingredients.Add(coffeeIngredient);
            Console.WriteLine($"Extra {coffeeIngredient} was added to {nameof(Cappuccino)}!");
        }

        public abstract void Print();
    }
}
