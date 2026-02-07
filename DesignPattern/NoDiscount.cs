namespace DesignPattern;

public class NoDiscount : IDiscountStrategy
{
    // Returns the original price unchanged
    public decimal ApplyDiscount(decimal price)
    {
        return price;
    }
}