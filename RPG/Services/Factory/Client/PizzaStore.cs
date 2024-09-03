using System;
using RPG.Services.Factory.Factory;
using RPG.Services.Factory.Products;

namespace RPG.Services.Factory.Client;

public class PizzaStore
{
    private readonly IPizzaStore _factory;

    public PizzaStore(IPizzaStore factory)
    {
        _factory = factory;
    }

    public Pizza OrderPizza(string type)
    {
        Pizza pizza = _factory.CreatePizza(type);
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        return pizza;
    }
}
