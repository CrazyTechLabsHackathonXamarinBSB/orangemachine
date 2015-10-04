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
    }
}
