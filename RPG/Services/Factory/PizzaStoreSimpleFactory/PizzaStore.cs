using RPG.Services.Factory.PizzaStoreSimpleFactory.Pizzas;
using RPG.Services.Factory.PizzaStoreSimpleFactory.SimpleFatories;

namespace RPG.Services.Factory.PizzaStoreSimpleFactory;

public class PizzaStore
{
    private readonly SimplePizzaFactory _factory;

    public PizzaStore(SimplePizzaFactory factory)
    {
        _factory = factory;
    }
    public Pizza OrderPizza(IngredientType type)
    {
        Pizza pizza = _factory.CreatePizza(type);
        if (pizza == null) return null;
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        return pizza;
    }
}
