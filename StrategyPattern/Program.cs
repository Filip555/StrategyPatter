using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //regular customer
            PriceList priceListForRegularCustomers = new PriceList(new LowPrice());
            Console.WriteLine($"Price for regular customers is: {priceListForRegularCustomers.ShowPriceOfTheProduct()}\n");

            //normal customer
            PriceList priceListForNormalCustomers = new PriceList(new NormalPrice());
            Console.WriteLine($"Price for normal customers is: {priceListForNormalCustomers.ShowPriceOfTheProduct()}\n");

            //special customer
            PriceList priceListForSpecialCustomers = new PriceList(new OverpricedPrice());
            Console.WriteLine($"Price for special customers is: {priceListForSpecialCustomers.ShowPriceOfTheProduct()}\n");

            Console.ReadKey();
        }
    }
}
