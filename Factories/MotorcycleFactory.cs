using Models;

namespace Factories
{
    // MotorcycleFactory skapar MotorcycleImpl-objekt
    public class MotorcycleFactory
    {
        // Metod för att skapa en motorcykel med angivna egenskaper
        public MotorcycleImpl CreateMotorcycle(string make, string model, int year, double mileage, string engineType)
        {
            return new MotorcycleImpl(make, model, year, mileage, engineType);
        }
    }
}
