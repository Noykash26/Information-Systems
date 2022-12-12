using System;

namespace scouts
{
    public class Vehicle
    {
        public int VehicleId;
        public VehicleType Type;
        public DateTime start;
        public DateTime End;
        public Country Source;
        private Country destination;
        public string Company;
        public int Price;

        public Vehicle (int VehicleId, VehicleType Type, DateTime start, DateTime End, Country Source, Country destination, string Company, int Price) { 

            this.VehicleId = VehicleId;
            this.Type = Type;
            this.start = start;
            this.End = End;
            this.Source = Source;
            this.destination = destination;
            this.Company = Company;
            this.Price = Price;
        }



        private Travelplan[] part_of2;

    }
}

