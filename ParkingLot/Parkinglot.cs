using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class Parkinglot : ICarFetch
    {
        private readonly int capacity;
        private readonly List<Car> parkedCars = new List<Car>();

        public Parkinglot(int capacity)
        {
            this.capacity = capacity;
        }

        public Car FetchCar(int? ticket)
        {
            var car = parkedCars.FirstOrDefault(c => c.GetHashCode() == ticket);
            parkedCars.Remove(car);
            return car;
        }

        public int? Park(Car car)
        {
            if (IsParkingLotFull())
            {
                return null;
            }

            parkedCars.Add(car);
            return car.GetHashCode();
        }

        private bool IsParkingLotFull()
        {
            return parkedCars.Count >= capacity;
        }
    }
}
