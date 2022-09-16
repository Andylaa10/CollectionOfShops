using CollectionOfShopsProject.Implementation;
using GeoCoordinatePortable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfShopsProject.Interfaces
{
    public interface IShop
    {
        string Name { get; }
        string Address { get; }
        string Website { get; }
        double Latidude { get; }
        double Longitude { get; }
        
        GeoCoordinate Coordinate { get; }
    }
}
