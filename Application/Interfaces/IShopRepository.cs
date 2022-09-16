using CollectionOfShopsProject.Implementation;
using GeoCoordinatePortable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IShopRepository
    {
        public List<Shop> FilterByLocation(List<Shop> source, GeoCoordinate x, int width, int height);

        public List<Shop> SortByDistance(List<Shop> source, GeoCoordinate x);
    }
}
