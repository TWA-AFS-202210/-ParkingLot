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
            var car = new Car();
            var parkinglot = new Parkinglot(1);
            var parkingboy = new ParkingBoy(new List<Parkinglot>() { parkinglot });
            //when
            var ticket = parkingboy.Park(car);
            //then
            Assert.Equal(car, parkinglot.FetchCar(ticket));
        }
    }
}
