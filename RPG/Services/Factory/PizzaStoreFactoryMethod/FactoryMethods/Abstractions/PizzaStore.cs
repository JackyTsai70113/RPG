using RPG.Services.Factory.PizzaStoreFactoryMethod.Products.Pizzas;

namespace RPG.Services.Factory.PizzaStoreFactoryMethod.FactoryMethods;

public abstract class PizzaStore
{
    public Pizza OrderPizza(IngredientType type)
    {
        Pizza pizza = CreatePizza(type);
        if (pizza == null)
            return null;
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        return pizza;
    }
    protected abstract Pizza CreatePizza(IngredientType type);
}
