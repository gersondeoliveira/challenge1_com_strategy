using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var carrinho = new List<CartItem>
        {
            new CartItem("Floratta", 1),
            new CartItem("Malbec", 1),
            new CartItem("Egeo", 1)
        };

        var calculator = new CheckoutService(StrategyFactory.Create());

        var total = calculator.Calculate(carrinho);

        Console.WriteLine($"Total da compra: R$ {total}");
    }
}
