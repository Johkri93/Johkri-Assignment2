namespace Interfaces
{
    public interface IVehicle : IDriveable
    {
        string Make { get; }
        string Model { get; }
        int Year { get; }
        double Mileage { get; }
    }
}
