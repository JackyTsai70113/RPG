namespace RPG.Services.Iterator.DinerMergerCafe;

public class Waitress
{
    private readonly IMenu[] menus;

    public Waitress(IMenu[] menus)
    {
        this.menus = menus;
    }
    public void PrintMenu()
    {
        Console.WriteLine("MENU\n----\n");
        foreach (var menu in menus)
        {
            Console.WriteLine(menu.GetName());
            PrintMenu(menu.CreateIterator());
        }
    }

    public void PrintVegetarianMenu()
    {
        Console.WriteLine("\nVEGETARIAN MENU\n");
        foreach (var menu in menus)
        {
            PrintVegetarianMenu(menu.CreateIterator());
        }
    }
    private static void PrintMenu(IEnumerator<MenuItem> iterator)
    {
        while (iterator.MoveNext())
        {
            Console.WriteLine(iterator.Current);
        }
    }
    private static void PrintVegetarianMenu(IEnumerator<MenuItem> iterator)
    {
        while (iterator.MoveNext())
        {
            if (iterator.Current.IsVegetarian)
                Console.WriteLine(iterator.Current);
        }
    }
}
