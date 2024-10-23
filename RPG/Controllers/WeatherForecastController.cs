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

        [HttpGet("show_animals")]
        public ActionResult ShowAnimals()
        {
            Services.Adapter.Ducks.Client.ShowAnimals();
            return Ok();
        }

        [HttpGet("operator_home_theater")]
        public ActionResult OperatorHomeTheater()
        {
            Services.Facade.HomeTheater.Client.OperatorHomeTheater();
            return Ok();
        }

        [HttpGet("order_beverage")]
        public ActionResult OrderBeverage()
        {
            Services.TemplateMethod.Barista.Client.OrderBeverage();
            return Ok();
        }

        [HttpGet("sort_ducks")]
        public ActionResult SortDucks()
        {
            Services.TemplateMethod.DuckSort.Client.SortDucks();
            return Ok();
        }

        [HttpGet("show_chocolate_boiler")]
        public ActionResult ShowChocolateBoiler()
        {
            Services.Singleton.ChocolateBoiler.Client.ShowChocolateBoiler();
            return Ok();
        }

        [HttpGet("show_cooler_and_hotter_singleton")]
        public ActionResult ShowCoolerAndHotterSingleton()
        {
            Services.Singleton.MultipleSingleton.Client.ShowCoolerAndHotterSingleton();
            return Ok();
        }

        [HttpGet("command_test")]
        public IActionResult CommandTest()
        {
            Services.Command.RemoteControlWithUndo.Client.RemoteControlTest();
            Console.WriteLine();
            Services.Command.RemoteControlWithUndo.Client.PartyTest();
            return Ok();
        }

        [HttpGet("iterator_test")]
        public IActionResult IteratorTest()
        {
            Services.Iterator.DinerMerger.Client.Test();
            Console.WriteLine();
            Services.Iterator.DinerMergerCafe.Client.Test();
            return Ok();
        }

        [HttpGet("composite_test")]
        public IActionResult CompositeTest()
        {
            Services.Composite.Menu.Client.Test();
            Console.WriteLine("=====");
            Services.Composite.MenuIterator.Client.Test();
            return Ok();
        }

        [HttpGet("state_test")]
        public IActionResult StateTest()
        {
            Services.State.Gumball.Client.Test();
            Console.WriteLine();
            // Services.Command.RemoteControlWithUndo.Client.PartyTest();
            return Ok();
        }
    }
}
