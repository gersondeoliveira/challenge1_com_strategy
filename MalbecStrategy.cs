public class MalbecStrategy : IDiscountStrategy
{
    private const decimal Price = 210;

    public decimal Calculate(int quantity)
    {
        if (quantity >= 2)
            return quantity * Price * 0.8m;

        return quantity * Price;
    }
}
