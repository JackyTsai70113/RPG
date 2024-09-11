using RPG.Services.Factory.PizzaStoreAbstractFactory.Products.Ingredients;

namespace RPG.Services.Factory.PizzaStoreAbstractFactory.AbstractFactory
{
    public interface IPizzaIngredientFactory
    {
        public ICheese CreateCheese();
        public IClam CreateClam();
        public IDough CreateDough();
        public IPepperoni CreatePepperoni();
        public ISauce CreateSauce();
        public IVeggie[] CreateVeggies();
    }
}
