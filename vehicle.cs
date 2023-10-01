using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My__Ride
{
    internal class Vehicle
    {
        string type;
        string model;
        string license_plate;

        public Vehicle()
        {
            type = "unknown";
            model = "unknown";
            license_plate = "unknown";
        }
        public Vehicle(string type, string model, string licensePlate)
        {
            Type = type;
            Model = model;
            License_plate = license_plate;
        }

        public virtual string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string License_plate
        {
            get { return license_plate; }
            set { license_plate = value; }
        }
    }
}
