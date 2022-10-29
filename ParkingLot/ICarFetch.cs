using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public interface ICarFetch
    {
        public Car FetchCar(int? ticket);
    }
}
