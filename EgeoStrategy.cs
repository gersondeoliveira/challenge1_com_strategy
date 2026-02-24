public class EgeoStrategy : IDiscountStrategy
{
    private const decimal Price = 33;

    public decimal Calculate(int quantity)
    {
        return quantity * Price;
    }
}
