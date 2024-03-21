namespace Assignment14.coffee
{
    public class FlatWhite : Coffee
    {
        public FlatWhite()
        {
            Console.WriteLine($"Started a {nameof(FlatWhite)} order!");
            Ingredients.Add(CoffeeIngredient.BLACK_COFFEE);
            Ingredients.Add(CoffeeIngredient.BLACK_COFFEE);
            Ingredients.Add(CoffeeIngredient.MILK);
        }

        public override void Print()
        {
            Console.WriteLine($"Obtained a {nameof(FlatWhite)} containing:");
            Console.WriteLine(Ingredients.Aggregate("", (stringResult, coffeeIngredient) => stringResult + coffeeIngredient.ToString() + "\n"));
        }
    }
}
