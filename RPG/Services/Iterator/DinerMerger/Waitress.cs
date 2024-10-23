namespace RPG.Services.Iterator.DinerMerger;

public class Waitress
{
    private readonly IMenu _pancakeHouseMenu;
    private readonly IMenu _dinerMenu;

    public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu)
    {
        _pancakeHouseMenu = pancakeHouseMenu;
        _dinerMenu = dinerMenu;
    }
    public void PrintMenu()
    {
        Console.WriteLine("MENU\n----\nBREAKFAST");
        PrintMenu(_pancakeHouseMenu.CreateIterator());
        Console.WriteLine("\nLUNCH");
        PrintMenu(_dinerMenu.CreateIterator());
    }

    public void PrintBreakfastMenu()
    {
        var pancakeHouseMenuIterator = _pancakeHouseMenu.CreateIterator();
        while (pancakeHouseMenuIterator.HasNext())
        {
            Console.WriteLine(pancakeHouseMenuIterator.Next());
        }
    }
    public void PrintLunchMenu()
    {
        var dinerMenuIterator = _dinerMenu.CreateIterator();
        while (dinerMenuIterator.HasNext())
        {
            Console.WriteLine(dinerMenuIterator.Next());
        }
    }
    public void PrintVegetarianMenu()
    {
        PrintVegetarianMenu(_pancakeHouseMenu.CreateIterator());
        PrintVegetarianMenu(_dinerMenu.CreateIterator());
    }
    private static void PrintMenu(IIterator<MenuItem> iterator)
    {
        while (iterator.HasNext())
        {
            Console.WriteLine(iterator.Next());
        }
    }
    private static void PrintVegetarianMenu(IIterator<MenuItem> iterator)
    {
        while (iterator.HasNext())
        {
            var menuItem = iterator.Next();
            if (menuItem.IsVegetarian)
                Console.WriteLine(menuItem);
        }
    }
    public bool IsVegetarian(string name, IIterator<MenuItem> iterator)
    {
        while (iterator.HasNext())
        {
            var menuItem = iterator.Next();
            if (menuItem.Name == name)
                return menuItem.IsVegetarian;
        }
        return false;
    }
}
