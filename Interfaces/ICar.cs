namespace Interfaces
{
    // ICar representerar en bil och ärver från IVehicle
    public interface ICar : IVehicle
    {
        // Antal dörrar på bilen
        int Doors { get; set; }
    }
}
