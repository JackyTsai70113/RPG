using RPG.Services.Factory.PizzaStoreSimpleFactory.Pizzas;

namespace RPG.Services.Factory.PizzaStoreSimpleFactory.SimpleFatories;

public class SimplePizzaFactory
{
    public Pizza CreatePizza(IngredientType type)
    {
        Pizza pizza;
        switch (type)
        {
            case IngredientType.Cheese:
                pizza = new CheesePizza();
                break;
            case IngredientType.Clam:
                pizza = new ClamPizza();
                break;
            case IngredientType.Pepperoni:
                pizza = new PepperoniPizza();
                break;
            case IngredientType.Veggie:
                pizza = new VeggiePizza();
                break;
            default:
                return null;
        }
        return pizza;
    }
}
