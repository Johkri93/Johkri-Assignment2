using Interfaces;

namespace Models
{
    public class MotorcycleImpl : IMotorcycle
    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public double Mileage { get; private set; }
        public string EngineType { get; set; }
        private bool engineOn;

        public MotorcycleImpl(string make, string model, int year, double mileage, string engineType)
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
            EngineType = engineType;
            engineOn = false;
        }

        public void StartEngine() => engineOn = true;

        public void StopEngine() => engineOn = false;

        public bool IsEngineOn() => engineOn;

        public override string ToString()
        {
            return $"Motorcycle: {Make} {Model} ({Year}), Engine: {EngineType}, Mileage: {Mileage}";
        }
    }
}
