using RPG.Services.Factory.PizzaStoreFactoryMethod.Products.Pizzas;

namespace RPG.Services.Factory.PizzaStoreFactoryMethod.FactoryMethods;

public class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(IngredientType type)
    {
        Pizza pizza = type switch
        {
            IngredientType.Cheese => new ChicagoStyleCheesePizza(),
            IngredientType.Clam => new ChicagoStyleClamPizza(),
            IngredientType.Pepperoni => new ChicagoStylePepperoniPizza(),
            IngredientType.Veggie => new ChicagoStyleVeggiePizza(),
            _ => null
        };
        return pizza;
    }
}
