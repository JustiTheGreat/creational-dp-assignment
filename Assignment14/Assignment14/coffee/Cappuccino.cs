namespace Assignment14.coffee
{
    public class Cappuccino : Coffee
    {
        public Cappuccino()
        {
            Console.WriteLine($"Started a {nameof(Cappuccino)} order!");
            Ingredients.Add(CoffeeIngredient.BLACK_COFFEE);
            Ingredients.Add(CoffeeIngredient.MILK);
        }

        public override void Print()
        {
            Console.WriteLine($"Obtained a {nameof(Cappuccino)} containing:");
            Console.WriteLine(Ingredients.Aggregate("", (stringResult, coffeeIngredient) => stringResult + coffeeIngredient.ToString() + "\n"));
        }
    }
}
