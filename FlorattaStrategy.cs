public class FlorattaStrategy : IDiscountStrategy
{
    private const decimal Price = 60;

    public decimal Calculate(int quantity)
    {
        int payable = (quantity / 2) + (quantity % 2);
        return payable * Price;
    }
}
