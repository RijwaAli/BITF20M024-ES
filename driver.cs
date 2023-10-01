using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace My__Ride
{
    internal class driver
    {
        string name;
        int age;
        string gender;
        string address;
        string phNo;
        location curr_loc;
        Vehicle vehicle;
        bool availability;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string PhNo
        {
            get
            {
                return phNo;
            }
            set
            {
                string validPhNo = new string(value.Where(char.IsDigit).ToArray());

                if (validPhNo == value)
                {
                    phNo = validPhNo;
                }
                else
                {
                    Console.WriteLine("Invalid number. Please enter a valid phone number with digits only no space or any other character required.");
                }
            }
        }
        public location Curr_loc
        {
            get
            {
                return curr_loc;
            }
            set
            {
                curr_loc = value;
            }
        }
        public Vehicle Vehicle
        {
            get
            {
                return vehicle;
            }
            set
            {
                vehicle = value;
            }
        }
        public bool Availability
        {
            get
            {
                return true;
            }
            set
            {
                availability = value;
            }
        }     
        public void UpdateAvailability()
        {
            Console.Write("Are you available for now or  for that time? true/false ");
            Console.Write("Are you available for now or  for that time? true/false ");
            if (bool.TryParse(Console.ReadLine(), out bool isAvailable))
            {
                Availability = availability;
                Console.WriteLine("  Ride is availabile updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'true' or 'false' to update availability nothing other than that.");
            }
        }
    }
}