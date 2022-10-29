using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class ParkingBoy : ICarFetch
    {
        private List<Parkinglot> parkinglots;

        public ParkingBoy(List<Parkinglot> parkinglots)
        {
            this.parkinglots = parkinglots;
        }

        public List<Parkinglot> Parkinglots
        {
            get { return parkinglots; }
        }

        public int? Park(Car car)
        {
            foreach (var parkinglot in Parkinglots)
            {
                var ticket = parkinglot.Park(car);

                if (ticket.HasValue)
                {
                    return ticket;
                }
            }

            return null;
        }

        public Car FetchCar(int? ticket)
        {
            foreach (var parkinglot in parkinglots)
            {
                var car = parkinglot.FetchCar(ticket);

                if (car != null)
                {
                    return car;
                }
            }

            return null;
        }
    }
}
