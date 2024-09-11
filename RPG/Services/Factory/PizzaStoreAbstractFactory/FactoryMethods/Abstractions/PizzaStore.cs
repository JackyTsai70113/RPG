using RPG.Services.Factory.PizzaStoreAbstractFactory.Products.Pizzas;

namespace RPG.Services.Factory.PizzaStoreAbstractFactory.FactoryMethods;

public abstract class PizzaStore
{
    protected abstract Pizza CreatePizza(IngredientType type);
    public Pizza OrderPizza(IngredientType type)
    {
        Pizza pizza = CreatePizza(type);
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        return pizza;
    }
}
