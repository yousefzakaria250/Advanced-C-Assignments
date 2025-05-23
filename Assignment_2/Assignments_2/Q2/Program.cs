




using Q2.Models;

Product product01 = new Product()
{
    Name = "Suger",
    Price =35,
    StockQuantity = 0
};

       // product01.Add();
       // Console.WriteLine(product01);

    var res = product01.Remove();
if (res)
    Console.WriteLine(product01);
else
    Console.WriteLine("Not Avaliable in Stock !!");