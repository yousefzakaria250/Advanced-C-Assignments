




using Q2.Models;

Product product01 = new Product()
{
    Name = "Suger",
    Price =35,
    StockQuantity = 0
};

if (product01.IsAvailable)
    Console.WriteLine(product01);

else
{
    product01.StockQuantity = 100;
    Console.WriteLine(product01);
}