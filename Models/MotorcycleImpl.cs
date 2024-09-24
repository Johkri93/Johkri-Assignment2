using Interfaces;

namespace Models
{
    // MotorcycleImpl implementerar IMotorcycle och representerar en motorcykel
    public class MotorcycleImpl : IMotorcycle
    {
        // Privat variabel för att hålla reda på om motorn är igång
        private bool engineOn;

        // Publika egenskaper för motorcykelns egenskaper
        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public double Mileage { get; private set; }
        public string EngineType { get; set; }

        // Konstruktor för att initiera en motorcykel med dess egenskaper
        public MotorcycleImpl(string make, string model, int year, double mileage, string engineType)
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
            EngineType = engineType;
            engineOn = false;  // Motorn är initialt avstängd
        }

        // Metod för att starta motorn
        public void StartEngine() => engineOn = true;

        // Metod för att stänga av motorn
        public void StopEngine() => engineOn = false;

        // Metod för att kontrollera om motorn är igång
        public bool IsEngineOn() => engineOn;

        // Override av ToString() för att ge en representativ sträng för motorcykelobjektet
        public override string ToString()
        {
            return $"Motorcycle: {Make} {Model} ({Year}), Engine: {EngineType}, Mileage: {Mileage}";
        }
    }
}
