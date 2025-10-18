using System;

class Stock
{
    public string StockName { get; set; }
    public string StockSymbol { get; set; }
    public double PreviousClosingPrice { get; set; }
    public double CurrentClosingPrice { get; set; }

    public Stock(string name, string symbol, double prevPrice, double curPrice)
    {
        StockName = name;
        StockSymbol = symbol;
        PreviousClosingPrice = prevPrice;
        CurrentClosingPrice = curPrice;
    }

    public double GetChangePercentage()
    {
        return ((CurrentClosingPrice - PreviousClosingPrice) / PreviousClosingPrice) * 100;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Stock s = new Stock("Reliance", "RELI", 2300.50, 2450.80);
        Console.WriteLine("Stock Name: " + s.StockName);
        Console.WriteLine("Stock Symbol: " + s.StockSymbol);
        Console.WriteLine("Previous Closing Price: " + s.PreviousClosingPrice);
        Console.WriteLine("Current Closing Price: " + s.CurrentClosingPrice);
        Console.WriteLine("Change %: " + s.GetChangePercentage());
    }
}
