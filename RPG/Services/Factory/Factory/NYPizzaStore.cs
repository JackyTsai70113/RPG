using RPG.Services.Factory.Products;

namespace RPG.Services.Factory.Factory;

public class NYPizzaFactory : IPizzaStore
{
    public override Pizza CreatePizza(string type)
    {
        Pizza pizza = type switch
        {
            "cheese" => new CheesePizza(),
            "Pepperoni" => new PepperoniPizza(),
            "clam" => new ClamPizza(),
            "veggie" => new VeggiePizza(),
            _ => throw new NotImplementedException(),
        };
        return pizza;
    }
}
