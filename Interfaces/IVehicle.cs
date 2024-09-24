namespace Interfaces
{
    // IVehicle representerar grundläggande egenskaper för ett fordon och ärver från IDriveable
    public interface IVehicle : IDriveable
    {
        // Fordonets märke
        string Make { get; }

        // Fordonets modell
        string Model { get; }

        // Fordonets tillverkningsår
        int Year { get; }

        // Fordonets körsträcka
        double Mileage { get; }
    }
}
