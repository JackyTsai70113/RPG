using System.Text;

namespace RPG.Services.Factory.PizzaStoreSimpleFactory.Pizzas;

public abstract class Pizza
{
    public string Name { get; protected set; } = "Unknown Name";
    public string Dough { get; protected set; } = "Unknown Dough";
    public string Sauce { get; protected set; } = "Unknown Sauce";
    public List<string> Toppings { get; protected set; } = new List<string>();

    public virtual void Prepare()
    {
        Console.WriteLine("Preparing " + Name);
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
        result.AppendLine(Dough);
        result.AppendLine(Sauce);
        foreach (var topping in Toppings)
        {
            result.AppendLine(topping);
        }

        return result.ToString();
    }
}
