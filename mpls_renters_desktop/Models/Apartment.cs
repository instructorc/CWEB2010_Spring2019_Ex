using System;
using System.Collections.Generic;
using System.Text;

namespace mpls_renters_desktop.Models
{
    class Apartment
    {
        public int property_id { get; set; }
        public string apartment_Name { get; set; }
        public int floor_count{ get; set; }
        public string website { get; set; }
        public string short_description { get; set; }
        public string long_description { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string contact_email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public int zip { get; set; }
        public string city_region { get; set; }
        public string facebook_url { get; set; }
        public string instagram_url { get; set; }
        public string tour_schedule_url { get; set; }
        public bool skyway_connected { get; set; }

        private readonly double ESTIMATED_RENT_ONE = 1200.00;
        private readonly double ESTIMATED_RENT_TWO = 2000.00;
        private readonly double ESTIMATED_RENT_THREE = 4000.00;
        //Default Constructor
        public Apartment()
        {

        }

        //Overloaded Constructor
        //public Apartment(string Name, string Address, int FloorCount, string RegionOfCity)
        //{
        //    this.Name = Name;
        //    this.Address = Address;
        //    this.FloorCount = FloorCount;

        //    if (RegionOfCity == "West" || RegionOfCity == "East" || RegionOfCity == "South" || RegionOfCity == "North" || RegionOfCity == "None")
        //    {
        //        this.RegionOfCity = RegionOfCity;
        //    }
        //    else
        //    {
        //        throw new CityRegionException(nameof(RegionOfCity));
        //    }

        //}
        public double estimatedRent()
        {
            return 3.00;
        }

        //public override string ToString()
        //{
        //    return String.Format("Name: {0} \n, Address: {1} \n, FloorCount: {2} \n, Region of City: {3} \n", Name, Address, FloorCount, RegionOfCity);
        //}
    }
}
