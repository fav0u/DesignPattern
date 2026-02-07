namespace DesignPattern;

public class PercentageDiscount : IDiscountStrategy
{
    private readonly decimal _percentage;

    // Percentage is injected via constructor
    public PercentageDiscount(decimal percentage)
    {
        _percentage = percentage;
    }

    // Calculates and applies the percentage discount
    public decimal ApplyDiscount(decimal price)
    {
        return price - (price * _percentage);
    }
}
