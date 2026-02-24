using System.Collections.Generic;

public class CheckoutService
{
    private readonly Dictionary<string, IDiscountStrategy> _strategies;

    public CheckoutService(Dictionary<string, IDiscountStrategy> strategies)
    {
        _strategies = strategies;
    }

    public decimal Calculate(List<CartItem> items)
    {
        decimal total = 0;

        foreach (var item in items)
        {
            if (!_strategies.TryGetValue(item.Product, out var strategy))
                throw new System.Exception($"Produto inválido: {item.Product}");

            total += strategy.Calculate(item.Quantity);
        }

        return total;
    }
}
