using RPG.Services.Factory.PizzaStoreFactoryMethod.Products.Pizzas;

namespace RPG.Services.Factory.PizzaStoreFactoryMethod.FactoryMethods;

public class NYPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(IngredientType type)
    {
        Pizza pizza = type switch
        {
            IngredientType.Cheese => new NYStyleCheesePizza(),
            IngredientType.Clam => new NYStyleClamPizza(),
            IngredientType.Pepperoni => new NYStylePepperoniPizza(),
            IngredientType.Veggie => new NYStyleVeggiePizza(),
            _ => null
        };
        return pizza;
    }
}
