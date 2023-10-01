using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My__Ride
{
    enum rideTypes { Bike, Rickshaw, Car };
    internal class Ride : Vehicle
    {
        location start_loc;
        location end_loc;
        int price;
        driver drivr;
        passenger pasnger;

        public Ride() : base()
        {
            start_loc = new location();
            end_loc = new location();
            drivr = new driver();
            pasnger = new passenger();
        }

        public location StartLocation
        {
            set
            {
                start_loc = value;
            }
            get
            {
                return start_loc;
            }
        }
        public location EndLocation
        {
            set
            {
                end_loc = value;
            }
            get
            {
                return end_loc;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public driver Driver
        {
            get
            {
                return drivr;
            }
        }
        public passenger Passenger
        {
            get
            {
                return pasnger;
            }
        }

        public override string Type
        {
            get => base.Type;
            set => base.Type = value;
        }
        public void assignPassenger(passenger pasnger)
        {
            this.pasnger = pasnger;
        }
        public void GetLocations()
        {
            Console.Write("Enter starting location: ");
            string startLocation = Console.ReadLine();
            Console.Write("Enter ending location: ");
            string endLocation = Console.ReadLine();

            StartLocation = start_loc;
            EndLocation = end_loc;
        }
    }
}