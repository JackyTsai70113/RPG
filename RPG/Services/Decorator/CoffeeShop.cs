using static RPG.Services.Decorator.Beverage;

namespace RPG.Services.Decorator;

public class CoffeeShop
{
    public void GetSomeCoffee()
    {
        Console.WriteLine($@"
~Coffee Shop~
    Coffee
        House Blend     0.89
        Dark Roast      0.99
        Decaf           1.05
        Expresso        1.99

    Condimment
        Milk            0.10
        Mocha           0.20
        Soy             0.10/0.15/0.20
        Whip            0.10
        ");
        Beverage beverage = new Expresso();
        Console.WriteLine($"{beverage.Description} ${beverage.Cost()}");

        Beverage beverage2 = new DarkRoast();
        beverage2 = new Mocha(beverage2);
        Console.WriteLine($"{beverage2.Description} ${beverage2.Cost()}");

        Beverage beverage3 = new HouseBlend();
        beverage3 = new Soy(beverage3);
        beverage3 = new Mocha(beverage3);
        beverage3 = new Whip(beverage3);
        Console.WriteLine($"{beverage3.Description} ${beverage3.Cost()}");

        Beverage beverage4 = new HouseBlend();
        beverage4.SetSize(SizeType.GRANDE);
        beverage4 = new Soy(beverage4);
        beverage4 = new Mocha(beverage4);
        beverage4 = new Mocha(beverage4);
        beverage4 = new Whip(beverage4);
        Console.WriteLine($"GRANDE: {beverage4.Description} ${beverage4.Cost()}, 1.54");

        beverage4 = new HouseBlend();
        beverage4.SetSize(SizeType.VENTI);
        beverage4 = new Soy(beverage4);
        beverage4 = new Mocha(beverage4);
        beverage4 = new Mocha(beverage4);
        beverage4 = new Whip(beverage4);
        Console.WriteLine($"VENTI: {beverage4.Description} ${beverage4.Cost()}, 1.59");

        Beverage beverage5 = new HouseBlend();
        beverage5 = new Soy(beverage5);
        beverage5 = new Mocha(beverage5);
        beverage5 = new Mocha(beverage5);
        beverage5 = new Whip(beverage5);
        Console.WriteLine($"{beverage5.Description} ${beverage5.Cost()}");
    }
}
