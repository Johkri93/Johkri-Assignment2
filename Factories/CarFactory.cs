using Models;

namespace Factories
{
    // CarFactory skapar CarImpl-objekt
    public class CarFactory
    {
        // Metod för att skapa en bil med angivna egenskaper
        public CarImpl CreateCar(string make, string model, int year, double mileage, int doors)
        {
            return new CarImpl(make, model, year, mileage, doors);
        }
    }
}
