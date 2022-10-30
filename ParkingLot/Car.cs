using System.Collections.Generic;
using System.Linq;

namespace ParkingLot
{
    public class Car
    {
        public Car(string name, string ticket, int limit)
        {
            Name = name;
            Ticket = ticket;
            Limit = limit;
        }

        public string Name { get; }
        public string Ticket { get; private set; }
        public List<string> Parking { get; private set; }
        private int Limit { get; }
        public string Park(string name)
        {
            for (int i = 0; i < Parking.Count; i++)
            {
                if (Parking[i] == "empty")
                {
                    Parking[i] = name;
                    return i.ToString();
                }
            }

            if (Parking.Count < Limit)
            {
                Parking.Add(name);
                Ticket = Parking.Count().ToString();
                return Ticket;
            }

            return "parking lot is ful";
        }

        public string GetCar(int ticket)
        {
            if (ticket >= 0 && ticket < Parking.Count())
            {
                var res = Parking[ticket];
                Parking[ticket] = "empty";
                return Parking[ticket];
            }

            return "wrong ticket";
        }
    }
}