using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

GeoLocation geoLocation = new GeoLocation();
ICoordinatesService coordinatesService = new GeoLocationAdapter(geoLocation);
var coordinates = coordinatesService.GetCoordinates();
Console.WriteLine($"Latitude: {coordinates.Latitude}, Longitude: {coordinates.Longitude}");
