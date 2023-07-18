public class Outdoor : Event
{
    private string _weatherForecast;
    public Outdoor(string title, string description, string date, string time, Address address, string weatherForecast) : base(title, description, date, time, address, "Outdoor Gathering")
    {
        _weatherForecast = weatherForecast;
    }
    public override string FullDetails()
    {
        return StandardDetails() + $"\nWeather Forecast: {_weatherForecast}\n";
    }
}