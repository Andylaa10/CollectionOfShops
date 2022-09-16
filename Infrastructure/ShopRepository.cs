using Application.Interfaces;
using CollectionOfShopsProject.Implementation;
using Domain.Interfaces;
using GeoCoordinatePortable;
using System;

namespace Infrastructure
{
    public class ShopRepository : IShopRepository
    {
        
        public ShopRepository()
        {
            
        }

        public List<Shop> FilterByLocation(List<Shop> source, GeoCoordinate x, int width, int height)
        {
            throw new NotImplementedException();
        }

        // https://stackoverflow.com/questions/10120944/finding-closest-value-in-an-array
        // https://ourcodeworld.com/articles/read/1470/how-to-find-the-closest-value-to-zero-from-an-array-with-positive-and-negative-numbers-in-javascript 
        public List<Shop> SortByDistance(List<Shop> source, GeoCoordinate x)
        {
            if (source.Count == 0 || x == null)
            {
                throw new InvalidOperationException("The list is be empty or the GeoCoordinate is null");
            }
            else
            {
                var closest = source.OrderBy(shop => shop.DistanceFromCoordinate = x.GetDistanceTo(shop.Coordinate)).ToList();
                return closest;
                //var closest = source.OrderBy(shop => Math.Abs((double)shop.Coordinate.GetDistanceTo(x))).ToList();
                //var closest = source.OrderBy(shop => Math.Abs((double)shop.Coordinate.GetDistanceTo(x)));
                //var closest = source.Select(shop => shop).Where(Math.Abs((double)s))
                //return null;
            }
        }
    }
}