namespace RPG.Services.Observer;

public class WeatherStation
{
    WeatherData weatherData;
    readonly CurrentConditionsDisplay currentConditionsDisplay;
    readonly StatisticsDisplay statisticsDisplay;
    readonly ForecastDisplay forecastDisplay;
    public WeatherStation()
    {
        weatherData = new WeatherData();
        currentConditionsDisplay = new(weatherData);
        statisticsDisplay = new(weatherData);
        forecastDisplay = new(weatherData);
    }
    public void RandomWeather()
    {
        weatherData.RandomWeather();
    }
    public void DoNotDisplayCurrentConditions()
    {
        currentConditionsDisplay.DoNotDisplay();
    }
    public void DoNotDisplayStatictics()
    {
        statisticsDisplay.DoNotDisplay();
    }
    public void DoNotDisplayForecast()
    {
        forecastDisplay.DoNotDisplay();
    }
}