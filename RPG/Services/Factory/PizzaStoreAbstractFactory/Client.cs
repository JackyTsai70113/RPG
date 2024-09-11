using RPG.Services.Factory.PizzaStoreAbstractFactory.FactoryMethods;
using RPG.Services.Factory.PizzaStoreAbstractFactory.Products.Pizzas;

namespace RPG.Services.Factory.PizzaStoreAbstractFactory
{
    public static class Client
    {
        public static void OrderPizza()
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza nyCheesePizza = nyStore.OrderPizza(IngredientType.Cheese);
            Console.WriteLine("Ethan ordered a\n" + nyCheesePizza);

            Pizza chicagoCheesePizza = chicagoStore.OrderPizza(IngredientType.Cheese);
            Console.WriteLine("Joel ordered a\n" + chicagoCheesePizza);

            Pizza nyClamPizza = nyStore.OrderPizza(IngredientType.Clam);
            Console.WriteLine("Ethan ordered a\n" + nyClamPizza);

            Pizza chicagoClamPizza = chicagoStore.OrderPizza(IngredientType.Clam);
            Console.WriteLine("Joel ordered a\n" + chicagoClamPizza);

            Pizza nyPepperoniPizza = nyStore.OrderPizza(IngredientType.Pepperoni);
            Console.WriteLine("Ethan ordered a\n" + nyPepperoniPizza);

            Pizza chicagoPepperoniPizza = chicagoStore.OrderPizza(IngredientType.Pepperoni);
            Console.WriteLine("Joel ordered a\n" + chicagoPepperoniPizza);

            Pizza nyVeggiePizza = nyStore.OrderPizza(IngredientType.Veggie);
            Console.WriteLine("Ethan ordered a\n" + nyVeggiePizza);

            Pizza chicagoVeggiePizza = chicagoStore.OrderPizza(IngredientType.Veggie);
            Console.WriteLine("Joel ordered a\n" + chicagoVeggiePizza);
        }
    }
}
