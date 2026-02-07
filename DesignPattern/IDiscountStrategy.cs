namespace DesignPattern;

public interface IDiscountStrategy
{
    // Applies a discount to the given price
    decimal ApplyDiscount(decimal price);
}