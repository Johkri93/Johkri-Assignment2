using Interfaces;

namespace Models
{
    public class CarImpl : ICar
    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public double Mileage { get; private set; }
        public int Doors { get; set; }
        private bool engineOn;

        public CarImpl(string make, string model, int year, double mileage, int doors)
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
            Doors = doors;
            engineOn = false;
        }

        public void StartEngine() => engineOn = true;

        public void StopEngine() => engineOn = false;

        public bool IsEngineOn() => engineOn;

        public override string ToString()
        {
            return $"Car: {Make} {Model} ({Year}), Doors: {Doors}, Mileage: {Mileage}";
        }
    }
}
