namespace RPG.Services.Composite.MenuIterator;

public class Waitress
{
    private readonly MenuComponent _allMenus;
    public Waitress(MenuComponent allMenus)
    {
        _allMenus = allMenus;
    }

    public void PrintMenu()
    {
        _allMenus.Print();
    }

    public void PrintVegetarianMenu()
    {
        var iterator = _allMenus.CreateIterator();
        while (iterator.MoveNext())
        {
            try
            {
                if (iterator.Current.IsVegetarian)
                {
                    iterator.Current.Print();
                }
            }
            catch (NotImplementedException) { }
        }
    }
}
