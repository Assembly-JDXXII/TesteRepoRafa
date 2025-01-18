using ConsoleApp1;


Car car1 = new Car("Red");

Console.WriteLine("Distance: " + car1.distance);

car1.fuel = 10;
car1.fuelEfficiency = 8;
car1.brand = new Brand();

car1.GoDistance(50);

Console.WriteLine("Distance: "+car1.distance);
Console.WriteLine("fuel: "+car1.fuel);
