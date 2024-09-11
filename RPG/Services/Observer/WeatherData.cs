namespace RPG.Services.Observer
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;
        public WeatherData()
        {
            observers = new();
        }
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }
        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }
        public void SetMeasurement(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
        public void RandomWeather()
        {
            var random = new Random();
            float temperature = (float)(random.NextDouble() % 120);
            float humidity = (float)(random.NextDouble() % 100);
            float pressure = (float)(random.NextDouble() % 30);
            SetMeasurement(temperature, humidity, pressure);
        }


    }
}
