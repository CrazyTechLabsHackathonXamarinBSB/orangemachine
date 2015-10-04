using Geolocator.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDionisio.Models
{
    class Coordinates
    {        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public async Task<Coordinates> GetGeolocator()
        {
            Coordinates coordinates = null;
            try
            {
                var locator = CrossGeolocator.Current;
                locator.DesiredAccuracy = 50;

                var position = await locator.GetPositionAsync(timeoutMilliseconds: 10000);
                coordinates = new Coordinates();
                coordinates.Latitude = position.Latitude;
                coordinates.Longitude = position.Longitude;
            }
            catch (Exception ex)
            {

            }

            return coordinates;
        }

        //Haversine formula
        //https://limzhenghong.wordpress.com/2013/11/04/calculate-distance-between-two-locations-with-latitude-and-longitude-c/
        public double Distance(double Latitude1, double Longitude1, double Latitude2, double Longitude2)
        {
            double R = 6371.0;          
            double dLat = this.toRadian(Latitude2 - Latitude1);
            double dLon = this.toRadian(Longitude2 - Longitude1);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Cos(this.toRadian(Latitude1)) * Math.Cos(this.toRadian(Latitude2)) * Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            double c = 2 * Math.Asin(Math.Min(1, Math.Sqrt(a)));
            double d = R * c;

            return d;
        }

        private double toRadian(double val)
        {
            return (Math.PI / 180) * val;
        }
    }
}
