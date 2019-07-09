using System;
using System.Collections.Generic;

namespace stock_purchase_report
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("AAPL", "Apple");
            stocks.Add("LYFT", "Lyft");
            stocks.Add("AMZN", "Amazon");

            var stockPurchases = new Dictionary<string, List<double>>();

            var GMPurchases = new List<double>();
            GMPurchases.Add(234.09);


            stockPurchases.Add(stocks["GM"], new List<{ 234.09 } >);
        }
    }
}
