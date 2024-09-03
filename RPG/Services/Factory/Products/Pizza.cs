namespace RPG.Services.Factory.Products;

public abstract class Pizza
{
    public virtual string Name { get; } = "Unknown Name";
    public virtual string Dough { get; } = "Unknown Dough";
    public virtual string Sauce { get; } = "Unknown Sauce";
    public void Prepare()
    {
        Console.WriteLine("Prepare " + Name);
        Console.WriteLine("Tossing dough...");
        Console.WriteLine("Adding sauce...");
        Console.WriteLine("Adding toppings: ");
    }
    public void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }
    public void Cut()
    {
        Console.WriteLine("Cut the pizza into diagonal slices");
    }
    public void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
    }
}
