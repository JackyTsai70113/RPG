
namespace RPG.Services.Composite.Menu;

public class Menu : MenuComponent
{
    private readonly List<MenuComponent> _menuComponents = new();
    public Menu(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public override string Name { get; }
    public override string Description { get; }

    public override void Add(MenuComponent menuComponent)
    {
        _menuComponents.Add(menuComponent);
    }

    public override void Remove(MenuComponent menuComponent)
    {
        _menuComponents.Remove(menuComponent);
    }

    public override MenuComponent GetChild(int i)
    {
        return _menuComponents[i];
    }

    public override void Print()
    {
        Console.WriteLine("\n" + Name + ", " + Description);
        Console.WriteLine("---------------------");

        foreach (var menuComponent in _menuComponents)
        {
            menuComponent?.Print();
        }
    }
}
