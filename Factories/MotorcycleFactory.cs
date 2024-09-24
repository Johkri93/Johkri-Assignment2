using Interfaces;
using Models;

namespace Factories
{
    public class MotorcycleFactory
    {
        public MotorcycleImpl CreateMotorcycle(string make, string model, int year, double mileage, string engineType)
        {
            return new MotorcycleImpl(make, model, year, mileage, engineType);
        }
    }
}
