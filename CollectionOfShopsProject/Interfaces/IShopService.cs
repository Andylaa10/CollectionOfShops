using CollectionOfShopsProject.Implementation;
using GeoCoordinatePortable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IShopService
    {
        /// <summary>
        ///     Return all shops in source, sorted according to their distance to location x
        /// </summary>
        /// <param name="source"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        List<Shop> SortByDistance(List<Shop> source, GeoCoordinate x);

        /// <summary>
        ///     Return all shop form source located in the rectangle defined by x, width and height
        ///     where x is the lower left corner of the rectangle. The unit of width and height is kilometer
        /// </summary>
        /// <param name="source"></param>
        /// <param name="x"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        List<Shop> FilterByLocation(List<Shop> source, GeoCoordinate x, int width, int height);
    }
}
