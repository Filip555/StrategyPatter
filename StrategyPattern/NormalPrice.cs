using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    class NormalPrice : ICalculatePrice
    {
        public float CalculatePrice(float price)
        {
            return price;
        }
    }
}
