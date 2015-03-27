using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace WPYAK.Helpers
{
    class Location
    {
        public static async Task<Geoposition> GetCurrentLocation()
        {
            var locator = new Geolocator();
            return await locator.GetGeopositionAsync();
        }
    }
}
