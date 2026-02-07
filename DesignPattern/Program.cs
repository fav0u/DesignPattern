// See https://aka.ms/new-console-template for more information

using DesignPattern;

class Program
{
    static void Main()
    {
        // Choose discount strategy at runtime
        IDiscountStrategy discountStrategy =
            new PercentageDiscount(0.10m);

        // Inject strategy into the context
        PriceCalculator calculator =
            new PriceCalculator(discountStrategy);

        // Calculate final price using the selected strategy
        decimal finalPrice = calculator.Calculate(100m);

        Console.WriteLine(finalPrice); // Output: 90
    }
}