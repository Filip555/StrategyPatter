using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    class LowPrice : ICalculatePrice
    {
        public float CalculatePrice(float price)
        {
            return price * 0.7f;
        }
    }
}
