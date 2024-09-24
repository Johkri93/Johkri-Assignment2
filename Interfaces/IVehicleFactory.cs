namespace Interfaces
{
    // IVehicleFactory representerar en fabrik som kan skapa fordon
    public interface IVehicleFactory
    {
        // Fabrik för att skapa en bil
        ICar CreateCar(string make, string model, int year, double mileage, int doors);

        // Fabrik för att skapa en motorcykel
        IMotorcycle CreateMotorcycle(string make, string model, int year, double mileage, string engineType);
    }
}
