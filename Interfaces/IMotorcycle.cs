namespace Interfaces
{
    // IMotorcycle representerar en motorcykel och ärver från IVehicle
    public interface IMotorcycle : IVehicle
    {
        // Motortyp på motorcykeln
        string EngineType { get; set; }
    }
}
