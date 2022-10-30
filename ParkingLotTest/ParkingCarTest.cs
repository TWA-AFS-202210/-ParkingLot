namespace ParkingLotTest
{
    using ParkingLot;
    using System.Collections.Generic;
    using Xunit;

    public class ParkingCarTest
    {
        [Fact]
        public void Should_Parking_boy_park_a_car_into_parkinglot_with_1_position()
        {
            //given
            //var car = new Car();
            var carsnum = 1;
            List<Car> carsNum = new List<Car>();
            for (int num = 0; num < carsnum; num++)
            {
                var car = new Car();
                carsNum.Add(car);
            }

            var parkinglot = new Parkinglot(2);
            var parkingboy = new ParkingBoy(new List<Parkinglot>() { parkinglot });
            //when
            var ticket = parkingboy.Park(carsNum);
            //then
            Assert.Equal(carsNum, parkinglot.FetchCar(ticket));
        }

        [Fact]
        public void Should_Parking_boy_fetch_a_car_with__right_ticket()
        {
            //given
            var carsnum = 1;
            List<Car> carsNum = new List<Car>();
            for (int num = 0; num < carsnum; num++)
            {
                var car = new Car();
                carsNum.Add(car);
            }

            var parkinglot = new Parkinglot(1);
            var parkingboy = new ParkingBoy(new List<Parkinglot>() { parkinglot });
            //when
            var ticket = parkinglot.Park(carsNum);
            //then
            Assert.Equal(carsNum, parkingboy.FetchCar(ticket));
        }

        [Fact]
        public void Should_Parking_boy_park_multiple_cars_into_parking_lot()
        {
            //given
            var cars = 5;
            List<Car> carsNum = new List<Car>();
            for (int num = 0; num < cars; num++)
            {
                var car = new Car();
                carsNum.Add(car);
            }

            var parkinglot = new Parkinglot(5);
            var parkingboy = new ParkingBoy(new List<Parkinglot>() { parkinglot });
            //when
            var ticket = parkingboy.Park(carsNum);
            //then
            Assert.Equal(carsNum, parkingboy.FetchCar(ticket));
        }

        [Fact]
        public void Should_Parking_boy_can_not_fetch_a_car_without_a_ticket()
        {
            //given
            var cars = 0;
            List<Car> carsNum = new List<Car>();
            for (int num = 0; num < cars; num++)
            {
                var car = new Car();
                carsNum.Add(car);
            }

            var parkinglot = new Parkinglot(5);
            var parkingboy = new ParkingBoy(new List<Parkinglot>() { parkinglot });
            //when
            var ticket = parkinglot.Park(carsNum);
            //then
            Assert.Null(parkingboy.FetchCar(ticket));
        }
    }
}
