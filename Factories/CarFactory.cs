using Interfaces;
using Models;

namespace Factories
{
    public class CarFactory
    {
        public CarImpl CreateCar(string make, string model, int year, double mileage, int doors)
        {
            return new CarImpl(make, model, year, mileage, doors);
        }
    }
}
