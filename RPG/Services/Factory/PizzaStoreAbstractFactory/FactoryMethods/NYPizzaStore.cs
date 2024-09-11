using RPG.Services.Factory.PizzaStoreAbstractFactory.AbstractFactory;
using RPG.Services.Factory.PizzaStoreAbstractFactory.Products.Pizzas;

namespace RPG.Services.Factory.PizzaStoreAbstractFactory.FactoryMethods;

public class NYPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(IngredientType type)
    {
        IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

        Pizza pizza = type switch
        {
            IngredientType.Cheese => new CheesePizza(ingredientFactory) { Name = "New York Style Cheese Pizza" },
            IngredientType.Veggie => new VeggiePizza(ingredientFactory) { Name = "New York Style Veggie Pizza" },
            IngredientType.Clam => new ClamPizza(ingredientFactory) { Name = "New York Style Clam Pizza" },
            IngredientType.Pepperoni => new PepperoniPizza(ingredientFactory) { Name = "New York Style Pepperoni Pizza" },
            _ => throw new NotImplementedException(),
        };
        return pizza;
    }
}
