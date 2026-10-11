public record Coordinates(double Latitude, double Longitude);

public interface ICoordinatesService
{
    Coordinates GetCoordinates();
}
