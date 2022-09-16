using Application.Interfaces;
using CollectionOfShopsProject.Implementation;
using Domain.Interfaces;
using GeoCoordinatePortable;
using System;

namespace Application
{
    public class ShopService : IShopService
    {
        private IShopRepository _shopRepository;

        public ShopService(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }

        public List<Shop> FilterByLocation(List<Shop> source, GeoCoordinate x, int width, int height)
        {
            throw new NotImplementedException();
        }

        public List<Shop> SortByDistance(List<Shop> source, GeoCoordinate x)
        {
            return _shopRepository.SortByDistance(source, x);
        }
    }
}