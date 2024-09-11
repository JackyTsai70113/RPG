using RPG.Services.Factory.PizzaStoreAbstractFactory.Products.Ingredients;

namespace RPG.Services.Factory.PizzaStoreAbstractFactory.AbstractFactory
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public IClam CreateClam()
        {
            return new FreshClam();
        }

        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
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
}
