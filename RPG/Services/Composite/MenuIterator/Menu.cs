namespace RPG.Services.Composite.MenuIterator;

public class Menu : MenuComponent
{
    private readonly List<MenuComponent> _menuComponents = new();
    private CompositeIterator _iterator;
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

    public override IEnumerator<MenuComponent> CreateIterator()
    {
        return _iterator ?? (_iterator = new CompositeIterator(_menuComponents.GetEnumerator()));
    }

    public override void Print()
    {
        Console.WriteLine("\n" + Name + ", " + Description);
        Console.WriteLine("---------------------");

        var iterator = _menuComponents.GetEnumerator();
        while (iterator.MoveNext())
        {
            MenuComponent menuComponent = iterator.Current;
            menuComponent?.Print();
        }
    }
}
