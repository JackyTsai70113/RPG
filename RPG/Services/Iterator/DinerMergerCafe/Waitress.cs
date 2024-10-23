namespace RPG.Services.Iterator.DinerMergerCafe;

public class Waitress
{
    private readonly IMenu _pancakeHouseMenu;
    private readonly IMenu _dinerMenu;
    private readonly IMenu _cafeMenu;

    public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu, IMenu cafeMenu)
    {
        _pancakeHouseMenu = pancakeHouseMenu;
        _dinerMenu = dinerMenu;
        _cafeMenu = cafeMenu;
    }
    public void PrintMenu()
    {
        Console.WriteLine("MENU\n----\nBREAKFAST");
        PrintMenu(_pancakeHouseMenu.CreateIterator());
        Console.WriteLine("\nLUNCH");
        PrintMenu(_dinerMenu.CreateIterator());
        Console.WriteLine("\nDINNER");
        PrintMenu(_cafeMenu.CreateIterator());
    }

    public void PrintVegetarianMenu()
    {
        Console.WriteLine("\nVEGETARIAN MENU\n---------------");
        PrintVegetarianMenu(_pancakeHouseMenu.CreateIterator());
        PrintVegetarianMenu(_dinerMenu.CreateIterator());
        PrintVegetarianMenu(_cafeMenu.CreateIterator());
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
