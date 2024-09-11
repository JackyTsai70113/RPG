using RPG.Services.Factory.PizzaStoreAbstractFactory.AbstractFactory;
using RPG.Services.Factory.PizzaStoreAbstractFactory.Products.Pizzas;

namespace RPG.Services.Factory.PizzaStoreAbstractFactory.FactoryMethods;

public class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(IngredientType type)
    {
        IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

        Pizza pizza = type switch
        {
            IngredientType.Cheese => new CheesePizza(ingredientFactory) { Name = "Chicago Style Cheese Pizza" },
            IngredientType.Veggie => new VeggiePizza(ingredientFactory) { Name = "Chicago Style Veggie Pizza" },
            IngredientType.Clam => new ClamPizza(ingredientFactory) { Name = "Chicago Style Clam Pizza" },
            IngredientType.Pepperoni => new PepperoniPizza(ingredientFactory) { Name = "Chicago Style Pepperoni Pizza" },
            _ => throw new NotImplementedException(),
        };
        return pizza;
    }
}
