using System;
using System.Collections.Generic;

namespace StockPurchaseReport
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

            stockPurchases.Add("GM", new List<double>() { 234.09, 66.66, 45.65 });
            stockPurchases.Add("CAT", new List<double>() { 333.67, 343.56, 9877.45 });
            stockPurchases.Add("LYFT", new List<double>() { 3345.06 });

            Console.WriteLine();
            foreach (var stock in stockPurchases)
            {
                var totalPurchases = new double();
                string companyName = "";

                // iterating over the dictionary of ticker names and full names to match the stockPurchases to stocks
                // in order to make the full name accessible to this function.
                foreach (KeyValuePair<string, string> stockInfo in stocks)
                {
                    if (stock.Key == stockInfo.Key)
                    {
                        companyName = stockInfo.Value;

                    }
                }

                // iterating over the list inside the dictionary of stockPurchases to accumulate all purchases
                stock.Value.ForEach(num => totalPurchases += num);

                // readable data
                Console.WriteLine($"Investor has spent a total of {totalPurchases} on the stock for {companyName}");
                Console.WriteLine();

            }
        }
    }
}
