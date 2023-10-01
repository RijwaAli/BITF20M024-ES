using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My__Ride
{
    internal class passenger
    {
        string name;
        string phoneNo;

        public passenger()
        {
            name = string.Empty;
            phoneNo = string.Empty;
        }
        public passenger(string nam, string pNo)
        {
            name = nam;
            phoneNo = pNo;
        }

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

        public string PhoneNo
        {
            get 
            { 
                return phoneNo; 
            }
            set
            { 
                phoneNo = value; 
            }
        }
        public void BookRide()
        {
            Console.Write("Enter starting location: ");
            string startLocation = Console.ReadLine();
            Console.Write("Enter ending location: ");
            string endLocation = Console.ReadLine();
        }
        public int GiveRating()
        {
            int rating = 0;

            while (rating < 1 || rating > 5)
            {
                Console.Write("Rate to your ride from 1 to 5: ");
                if (int.TryParse(Console.ReadLine(), out rating))
                {
                    if (rating < 1 || rating > 5)
                    {
                        Console.WriteLine("You are rating out of the range. Please enter a number within 1 and 5.");
                    }
                }
                else
                {
                    Console.WriteLine("You are rating out of the range. Please enter a valid number within 1 and 5.");
                }
            }
            return rating;
        }
    }
}
