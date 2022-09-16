using CollectionOfShopsProject.Interfaces;
using GeoCoordinatePortable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfShopsProject.Implementation
{
    public class Shop : IShop
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Website { get; set; }

        public double Latidude { get; set; }

        public double Longitude { get; set; }

        public GeoCoordinate Coordinate { get; set; }

        public double DistanceFromCoordinate { get; set; }


        public Shop()
        {
            //Coordinate = new GeoCoordinate(Latidude, Longitude);
        }

        public override string? ToString()
        {
            return $"{Name} {Address} {Website} Coordinate: {Coordinate}";
        }
    }
}
