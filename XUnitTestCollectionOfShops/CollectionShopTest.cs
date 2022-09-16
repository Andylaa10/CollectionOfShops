using Application;
using Application.Interfaces;
using CollectionOfShopsProject.Implementation;
using CollectionOfShopsProject.Interfaces;
using Domain.Interfaces;
using GeoCoordinatePortable;
using Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace XUnitTestCollectionOfShops
{
    public class CollectionShopTest
    {
        [Fact]
        public void CreateShop()
        {
            // Arrange
            IShop shop;

            // Act
            shop = new Shop();

            // Assert
            Assert.NotNull(shop);
            Assert.True(shop is Shop);
        }

        [Fact]
        public void SortByDistanceValid()
        {
            // Arrange

            // Repository
            IShopRepository repo = new ShopRepository();


            GeoCoordinate shop1Geo = new GeoCoordinate(32, 2);
            GeoCoordinate shop2Geo = new GeoCoordinate(12, 21);
            GeoCoordinate shop3Geo = new GeoCoordinate(4, 7);


            // Shops
            IShop shop1 = new Shop() { Name = "Andy", Address = "Dog vej 332", Website = "www.GG.com", Latidude = shop1Geo.Latitude, Longitude = shop1Geo.Longitude, Coordinate = shop1Geo };
            IShop shop2 = new Shop() { Name = "Kristian", Address = "Cat vej 1", Website = "www.BG.com", Latidude = shop2Geo.Latitude, Longitude = shop2Geo.Longitude, Coordinate = shop2Geo };
            IShop shop3 = new Shop() { Name = "Marucs", Address = "Donkey vej 6", Website = "www.BB.com", Latidude = shop3Geo.Latitude, Longitude = shop3Geo.Longitude, Coordinate = shop3Geo };

            // GeoCoordinates
            GeoCoordinate geo = new GeoCoordinate(23, 12);

            // List
            List<Shop> shops = new List<Shop>();
            shops.Add((Shop)shop1);
            shops.Add((Shop)shop2);
            shops.Add((Shop)shop3);

            // Act

            var expected1 = repo.SortByDistance(shops, geo).First();

            // Assert
            Assert.Equal(shop2, expected1); 
             
        }

        [Fact]
        public void SortByDistanceInValid()
        {
            // Arrange
            IShopRepository repo = new ShopRepository();
            List<Shop> shops = new List<Shop>();
            GeoCoordinate geo = null; 

            // Act
            var ex = Assert.Throws<InvalidOperationException>(()=>repo.SortByDistance(shops, geo));

            // assert
            Assert.Equal("The list is be empty or the GeoCoordinate is null", ex.Message);
        }

        [Fact]
        public void FilterByLocationValid()
        {
            // Arrange

            // Act

            // assert
        }

        [Fact]
        public void FilterByLocationInValid()
        {
            // Arrange

            // Act

            // assert
        }
    }
}