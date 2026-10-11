using System.Globalization;

public class GeoLocationAdapter : ICoordinatesService
{
    private readonly GeoLocation _geoLocation;

    public GeoLocationAdapter(GeoLocation geoLocation)
    {
        _geoLocation = geoLocation;
    }

    public Coordinates GetCoordinates()
    {
        var parts = _geoLocation.GetLocation().Split(',');

        if (parts.Length != 2)
            throw new FormatException("Expected format: \"latitude, longitude\".");

        var latitude = double.Parse(parts[0].Trim(), CultureInfo.InvariantCulture);
        var longitude = double.Parse(parts[1].Trim(), CultureInfo.InvariantCulture);

        return new Coordinates(latitude, longitude);
    }
}
