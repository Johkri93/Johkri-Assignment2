using Factories;
using Models;

class Program
{
    static void Main(string[] args)
    {
        // Skapa fabriker för bilar och motorcyklar
        CarFactory carFactory = new CarFactory();
        MotorcycleFactory motorcycleFactory = new MotorcycleFactory();

        // Skapa en bil med CarFactory
        var car = carFactory.CreateCar("Toyota", "Corolla", 2020, 15000, 4);
        Console.WriteLine(car);

        // Starta motorn på bilen och kontrollera status
        car.StartEngine();
        Console.WriteLine("Car engine status: " + (car.IsEngineOn() ? "On" : "Off"));
        car.StopEngine();
        Console.WriteLine("Car engine status: " + (car.IsEngineOn() ? "On" : "Off"));

        // Ändra och visa antalet dörrar på bilen
        Console.WriteLine("Car doors: " + car.Doors);
        car.Doors = 5;
        Console.WriteLine("Car doors: " + car.Doors);

        // Skapa en motorcykel med MotorcycleFactory
        var motorcycle = motorcycleFactory.CreateMotorcycle("Harley Davidson", "Sportster", 2019, 5000, "V-Twin");
        Console.WriteLine(motorcycle);

        // Starta motorn på motorcykeln och kontrollera status
        motorcycle.StartEngine();
        Console.WriteLine("Motorcycle engine status: " + (motorcycle.IsEngineOn() ? "On" : "Off"));
        motorcycle.StopEngine();
        Console.WriteLine("Motorcycle engine status: " + (motorcycle.IsEngineOn() ? "On" : "Off"));

        // Ändra och visa motortypen på motorcykeln
        Console.WriteLine("Motorcycle engine type: " + motorcycle.EngineType);
        motorcycle.EngineType = "Inline-4";
        Console.WriteLine("Motorcycle engine type: " + motorcycle.EngineType);
    }
}
