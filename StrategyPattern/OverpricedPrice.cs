using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
class OverpricedPrice : ICalculatePrice
{
    public float CalculatePrice(float price)
    {
        return price * 1.3f;
    }
}
}
