using System.Text;

namespace RPG.Services.Factory.PizzaStoreFactoryMethod.Products.Pizzas;

public abstract class Pizza
{
    public string Name { get; protected set; } = "Unknown Name";
    public string Dough { get; protected set; } = "Unknown Dough";
    public string Sauce { get; protected set; } = "Unknown Sauce";
    public List<string> Toppings { get; protected set; } = new();

    public void Prepare()
    {
        Console.WriteLine("Prepare " + Name);
        Console.WriteLine("Tossing dough...");
        Console.WriteLine("Adding sauce...");
        Console.WriteLine("Adding toppings:");
        foreach (string topping in Toppings)
        {
            Console.WriteLine("    " + topping);
        }
    }

    public virtual void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }

    public virtual void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }

    public virtual void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
    }

    public override string ToString()
    {
        var result = new StringBuilder();
        result.AppendLine("---- " + Name + " ----");
        if (Dough != null)
        {
            result.AppendLine(Dough);
        }
        if (Sauce != null)
        {
            result.AppendLine(Sauce);
        }
        return result.ToString();
    }
}
