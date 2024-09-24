using Factories;
using Models;
using Interfaces;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Skapa fabriker för bilar och motorcyklar
        CarFactory carFactory = new CarFactory();
        MotorcycleFactory motorcycleFactory = new MotorcycleFactory();

        // Skapa en lista av IVehicle (både bilar och motorcyklar)
        List<IVehicle> vehicles = new List<IVehicle>
        {
            carFactory.CreateCar("Toyota", "Corolla", 2020, 15000, 4),
            motorcycleFactory.CreateMotorcycle("Harley Davidson", "Sportster", 2019, 5000, "V-Twin"),
            carFactory.CreateCar("Honda", "Civic", 2018, 20000, 4),
            motorcycleFactory.CreateMotorcycle("Yamaha", "MT-07", 2021, 3000, "Parallel Twin"),
            carFactory.CreateCar("Ford", "Mustang", 2022, 5000, 2),
            motorcycleFactory.CreateMotorcycle("Kawasaki", "Ninja", 2020, 6000, "Inline-4")
        };

        // Iterera över listan av fordon och anropa metoder beroende på fordonstypen
        foreach (var vehicle in vehicles)
        {
            // Skriv ut fordonets egenskaper (via ToString-metoden)
            Console.WriteLine(vehicle);

            // Starta motorn och skriv ut status (gäller alla fordon)
            vehicle.StartEngine();
            Console.WriteLine("Engine status: " + (vehicle.IsEngineOn() ? "On" : "Off"));

            // Stäng av motorn och skriv ut status (gäller alla fordon)
            vehicle.StopEngine();
            Console.WriteLine("Engine status: " + (vehicle.IsEngineOn() ? "On" : "Off"));

            // Kontrollera om fordonet är en bil och hantera specifika bil-egenskaper
            if (vehicle is ICar car)
            {
                Console.WriteLine("Car doors: " + car.Doors);
                car.Doors = 5; // Ändra antalet dörrar
                Console.WriteLine("Car doors (updated): " + car.Doors);
            }
            // Kontrollera om fordonet är en motorcykel och hantera specifika motorcykel-egenskaper
            else if (vehicle is IMotorcycle motorcycle)
            {
                Console.WriteLine("Motorcycle engine type: " + motorcycle.EngineType);
                motorcycle.EngineType = "Inline-4"; // Ändra motortyp
                Console.WriteLine("Motorcycle engine type (updated): " + motorcycle.EngineType);
            }

            // Tom rad för att separera fordonets utskrift
            Console.WriteLine();
        }
    }
}
