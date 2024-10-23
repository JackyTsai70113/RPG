using RPG.Services.Factory.PizzaStoreSimpleFactory.Pizzas;
using RPG.Services.Factory.PizzaStoreSimpleFactory.SimpleFatories;

namespace RPG.Services.Factory.PizzaStoreSimpleFactory;

public static class Client
{
    public static void OrderPizza()
    {
        SimplePizzaFactory factory = new();
        PizzaStore store = new(factory);

        Pizza cheesePizza = store.OrderPizza(IngredientType.Cheese);
        if (cheesePizza != null)
        {
            Console.WriteLine("We ordered a " + cheesePizza.Name);
        }

        Pizza veggiePizza = store.OrderPizza(IngredientType.Veggie);
        if (veggiePizza != null)
        {
            Console.WriteLine("We ordered a " + veggiePizza.Name);
        }
    }
}
