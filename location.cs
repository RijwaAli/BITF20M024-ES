using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My__Ride
{ 
    internal class location
    {
        float latitude;
        float longitude;
        public void setLocation(float longitude, float latitude)
        {
            this.longitude = longitude;
            this.latitude = latitude;
        }
        public float getLatitude() 
        {
            return latitude; 
        }
        public float getLongitude() 
        {
            return longitude; 
        }
    }
}

