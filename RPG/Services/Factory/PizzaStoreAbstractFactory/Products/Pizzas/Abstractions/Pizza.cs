using System.Text;
using RPG.Services.Factory.PizzaStoreAbstractFactory.Products.Ingredients;

namespace RPG.Services.Factory.PizzaStoreAbstractFactory.Products.Pizzas;

public abstract class Pizza
{
    public string Name { get; set; } = "Unknown Name";

    public IDough? Dough { get; protected set; }
    public ISauce? Sauce { get; protected set; }
    public IVeggie[] Veggies { get; protected set; } = Array.Empty<IVeggie>();
    public ICheese? Cheese { get; protected set; }
    public IPepperoni? Pepperoni { get; protected set; }
    public IClam? Clam { get; protected set; }

    public abstract void Prepare();

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
            result.AppendLine(Dough.ToString());
        }
        if (Sauce != null)
        {
            result.AppendLine(Sauce.ToString());
        }
        if (Cheese != null)
        {
            result.AppendLine(Cheese.ToString());
        }
        if (Veggies != null && Veggies.Any())
        {
            for (int i = 0; i < Veggies.Length; i++)
            {
                result.Append(Veggies[i].ToString());
                if (i < Veggies.Length - 1)
                {
                    result.Append(", ");
                }
            }
            result.Append('\n');
        }
        if (Clam != null)
        {
            result.AppendLine(Clam.ToString());
        }
        if (Pepperoni != null)
        {
            result.AppendLine(Pepperoni.ToString());
        }

        return result.ToString();
    }
}
