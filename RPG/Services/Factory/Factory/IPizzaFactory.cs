using RPG.Services.Factory.Products;

namespace RPG.Services.Factory.Factory;

public abstract class IPizzaStore
{
    public Pizza OrderPizza(string type)
    {
        Pizza pizza = CreatePizza(type);
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        return pizza;
    }
    public abstract Pizza CreatePizza(string type);
}
