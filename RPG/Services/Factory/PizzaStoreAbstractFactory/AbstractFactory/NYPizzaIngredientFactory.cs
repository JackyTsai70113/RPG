using RPG.Services.Factory.PizzaStoreAbstractFactory.Products.Ingredients;

namespace RPG.Services.Factory.PizzaStoreAbstractFactory.AbstractFactory;

public class NYPizzaIngredientFactory : IPizzaIngredientFactory
{
    public ICheese CreateCheese()
    {
        return new ReggianoCheese();
    }

    public IClam CreateClam()
    {
        return new FreshClam();
    }

    public IDough CreateDough()
    {
        return new ThinCrustDough();
    }

    public IPepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public ISauce CreateSauce()
    {
        return new MarinaraSauce();
    }

    public IVeggie[] CreateVeggies()
    {
        IVeggie[] veggies = new IVeggie[]{
                new Garlic(),
                new Onion(),
                new Mushroom(),
                new RedPepper()
            };
        return veggies;
    }
}

