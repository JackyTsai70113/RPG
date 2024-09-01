namespace RPG.Services.Decorator;

public class CoffeeShop
{
    public void GetSomeCoffee()
    {
        Beverage beverage = new Expresso();
        Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");

        Beverage beverage2 = new DarkRoast();
        beverage2 = new Mocha(beverage2);
        beverage2 = new Mocha(beverage2);
        beverage2 = new Whip(beverage2);
        Console.WriteLine($"{beverage2.GetDescription()} ${beverage2.Cost()}");

        Beverage beverage3 = new HouseBlend();
        beverage3 = new Soy(beverage3);
        beverage3 = new Mocha(beverage3);
        beverage3 = new Whip(beverage3);
        Console.WriteLine($"{beverage3.GetDescription()} ${beverage3.Cost()}");

        Beverage beverage4 = new HouseBlend();
        beverage4 = new Soy(beverage4);
        beverage4 = new Mocha(beverage4);
        beverage4 = new Mocha(beverage4);
        beverage4 = new Whip(beverage4);
        Console.WriteLine($"{beverage4.GetDescription()} ${beverage4.Cost()}");
    }
}
