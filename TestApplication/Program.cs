// See https://aka.ms/new-console-template for more information
using Application;
using Application.Interfaces;
using CollectionOfShopsProject.Implementation;
using CollectionOfShopsProject.Interfaces;
using Domain.Interfaces;
using GeoCoordinatePortable;
using Infrastructure;

Console.WriteLine("Hello, World!");

IShopRepository repo = new ShopRepository();

GeoCoordinate shop1Geo = new GeoCoordinate(10, 10);
GeoCoordinate shop2Geo = new GeoCoordinate(25, 25);
GeoCoordinate shop3Geo = new GeoCoordinate(50, 50);


// Shops
IShop shop1 = new Shop() { Name = "Andy", Address = "Dog vej 332", Website = "www.GG.com", Coordinate = shop1Geo };
IShop shop2 = new Shop() { Name = "Kristian", Address = "Cat vej 1", Website = "www.BG.com", Coordinate = shop2Geo };
IShop shop3 = new Shop() { Name = "Marucs", Address = "Donkey vej 6", Website = "www.BB.com", Coordinate = shop3Geo };

// GeoCoordinates
GeoCoordinate geo = new GeoCoordinate(15, 35);

// List
List<Shop> shops = new List<Shop>();
shops.Add((Shop)shop1);
shops.Add((Shop)shop2);
shops.Add((Shop)shop3);

foreach (Shop s in repo.SortByDistance(shops, geo))
{
    Console.WriteLine(s.ToString() + "\n");
}
