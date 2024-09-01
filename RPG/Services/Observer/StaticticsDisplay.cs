namespace RPG.Services.Observer;

public class StatisticsDisplay : IObserver, IDisplayElement
{
    private float maxTemp = 0.0f;
    private float minTemp = 200;
    private float tempSum = 0.0f;
    private int numReadings;
    private readonly WeatherData weatherData;
    public StatisticsDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }
    public void Update(float temperature, float humidity, float pressure)
    {
        maxTemp = Math.Max(maxTemp, temperature);
        minTemp = Math.Max(minTemp, temperature);
        tempSum += temperature;
        numReadings++;
        Display();
    }
    public void Display()
    {
        Console.WriteLine($"Avg/Max/Min temperature = {tempSum / numReadings}/{maxTemp}/{minTemp}");
    }

    public void DoNotDisplay()
    {
        weatherData.RemoveObserver(this);
    }
}
