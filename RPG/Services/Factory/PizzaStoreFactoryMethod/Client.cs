
using RPG.Services.Factory.PizzaStoreFactoryMethod.FactoryMethods;
using RPG.Services.Factory.PizzaStoreFactoryMethod.Products.Pizzas;

namespace RPG.Services.Factory.PizzaStoreFactoryMethod;

public static class Client
{
    public static void OrderPizza()
    {
        PizzaStore nyStore = new NYPizzaStore();
        PizzaStore chicagoStore = new ChicagoPizzaStore();

        Pizza? nyCheesePizza = nyStore.OrderPizza(IngredientType.Cheese);
        if (nyCheesePizza != null)
        {
            Console.WriteLine("Ethan ordered a\n" + nyCheesePizza.ToString());
        }

        Pizza? chicagoCheesePizza = chicagoStore.OrderPizza(IngredientType.Cheese);
        if (chicagoCheesePizza != null)
        {
            Console.WriteLine("Joel ordered a\n" + chicagoCheesePizza.ToString());
        }
    }
}
