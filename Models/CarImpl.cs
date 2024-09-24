using Interfaces;

namespace Models
{
    // CarImpl implementerar ICar interfacet och representerar en bil
    public class CarImpl : ICar
    {
        // Privat variabel för att hålla reda på om motorn är igång
        private bool engineOn;

        // Publika egenskaper för bilens egenskaper
        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public double Mileage { get; private set; }
        public int Doors { get; set; }

        // Konstruktor för att initiera en bil med dess egenskaper
        public CarImpl(string make, string model, int year, double mileage, int doors)
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
            Doors = doors;
            engineOn = false;  // Motorn är initialt avstängd
        }

        // Metod för att starta motorn
        public void StartEngine() => engineOn = true;

        // Metod för att stänga av motorn
        public void StopEngine() => engineOn = false;

        // Metod för att kontrollera om motorn är igång
        public bool IsEngineOn() => engineOn;

        // Override av ToString() för att ge en representativ sträng för bilobjektet
        public override string ToString()
        {
            return $"Car: {Make} {Model} ({Year}), Doors: {Doors}, Mileage: {Mileage}";
        }
    }
}
