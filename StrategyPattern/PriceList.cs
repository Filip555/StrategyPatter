using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
class PriceList
{
    private readonly ICalculatePrice _priceCalculator;
    private readonly float productPrice = 60;

    public PriceList(ICalculatePrice priceCalculator)
    {
        _priceCalculator = priceCalculator;
    }

    public float ShowPriceOfTheProduct()
    {
        return _priceCalculator.CalculatePrice(productPrice);
    }
}
}
