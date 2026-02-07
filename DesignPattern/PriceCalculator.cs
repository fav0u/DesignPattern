namespace DesignPattern;

public class PriceCalculator
{
    private readonly IDiscountStrategy _discountStrategy;

    // Strategy is injected (composition over inheritance)
    public PriceCalculator(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    // Delegates discount logic to the strategy
    public decimal Calculate(decimal price)
    {
        return _discountStrategy.ApplyDiscount(price);
    }
}