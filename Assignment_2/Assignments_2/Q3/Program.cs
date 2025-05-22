






using Q3.Models;

Car car = new Car
{
    Make="Japan",
    Model ="Toyota",
    Year = 2018
};

var distance = car.Drive(40);

Console.WriteLine(car);
Console.WriteLine(distance);    


