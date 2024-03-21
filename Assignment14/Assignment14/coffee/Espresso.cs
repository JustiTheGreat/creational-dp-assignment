namespace Assignment14.coffee
{
    public class Espresso : Coffee
    {
        public Espresso()
        {
            Console.WriteLine($"Started a {nameof(Espresso)} order!");
            Ingredients.Add(CoffeeIngredient.BLACK_COFFEE);
        }

        public override void Print()
        {
            Console.WriteLine($"Obtained a {nameof(Espresso)} containing:");
            Console.WriteLine(Ingredients.Aggregate("", (stringResult, coffeeIngredient) => stringResult + coffeeIngredient.ToString() + "\n"));
        }
    }
}
