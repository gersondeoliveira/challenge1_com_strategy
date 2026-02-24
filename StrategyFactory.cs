using System.Collections.Generic;

public static class StrategyFactory
{
    public static Dictionary<string, IDiscountStrategy> Create()
    {
        return new Dictionary<string, IDiscountStrategy>(System.StringComparer.OrdinalIgnoreCase)
        {
            { "Floratta", new FlorattaStrategy() },
            { "Malbec", new MalbecStrategy() },
            { "Egeo", new EgeoStrategy() }
        };
    }
}
