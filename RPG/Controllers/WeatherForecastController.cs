using Microsoft.AspNetCore.Mvc;
using RPG.Services.Characters;
using RPG.Services.Decorator;
using RPG.Services.Observer;

namespace RPG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("King")]
        public ActionResult KingAct()
        {
            var king = new King();
            king.Fight();
            king.RandomWeapon();
            king.Fight();
            return Ok();
        }

        [HttpGet("ChangeWeather")]
        public ActionResult ChangeWeather()
        {
            var weatherStation = new WeatherStation();
            weatherStation.RandomWeather();
            weatherStation.DoNotDisplayStatictics();
            weatherStation.RandomWeather();
            return Ok();
        }

        [HttpGet("coffee")]
        public ActionResult GetCoffee()
        {
            new CoffeeShop().GetSomeCoffee();
            return Ok();
        }

        [HttpGet("simple_factory_order_pizza")]
        public ActionResult SimpleFactoryOrderPizza()
        {
            Services.Factory.PizzaStoreSimpleFactory.Client.OrderPizza();
            return Ok();
        }

        [HttpGet("factory_method_order_pizza")]
        public ActionResult FactoryMethodOrderPizza()
        {
            Services.Factory.PizzaStoreFactoryMethod.Client.OrderPizza();
            return Ok();
        }

        [HttpGet("abstract_factory_order_pizza")]
        public ActionResult AbstractFactoryOrderPizza()
        {
            Services.Factory.PizzaStoreAbstractFactory.Client.OrderPizza();
            return Ok();
        }
    }
}
