using ParkingLot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ParkingLotTest
{
    public class ParkingCarTestForStoryThree
    {
        [Fact]
        public void Should_Parking_boy_park_car_to_parking_lot2_when_lot1_is_full()
        {
            //given
            var carsnum = 10;
            List<Car> cars = CarsNum(carsnum);
            var car_11 = new List<Car>() { new Car() };
            var parkinglot1 = new Parkinglot(10);
            var parkinglot2 = new Parkinglot(10);
            var parkingboy = new ParkingBoy(new List<Parkinglot>() { parkinglot1, parkinglot2 });
            parkinglot1.Park(cars);
            //when
            var ticket = parkingboy.Park(car_11);
            //then
            Assert.Equal(0, parkinglot1.FetchCar(ticket).Count);
            Assert.Equal(car_11, parkinglot2.FetchCar(ticket));
        }

        public List<Car> CarsNum(int cars)
        {
            List<Car> carsNum = new List<Car>();
            for (int num = 0; num < cars; num++)
            {
                var car = new Car();
                carsNum.Add(car);
            }

            return carsNum;
        }
    }
}
