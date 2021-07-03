using System;

namespace GameApp
{
    public class Reservation
    {
        public string provincestate { get; set; }
        public string countryregion { get; set; }
        public DateTime lastupdate { get; set; }
        public Location Location { get; set; }
        public CountryCode countrycode { get; set; }
        public string confirmed { get; set; }
        public string deaths { get; set; }
        public string recovered { get; set; }
    }

    public class CountryCode
    {
        public string iso2 { get; set; }
        public string iso3 { get; set; }
        
    }

    public class Location
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }
}