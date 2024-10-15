namespace RPG.Services.Iterator.DinerMerger;

public class Waitress
{
    private readonly PancakeHouseMenu pancakeHouseMenu;
    private readonly DinerMenu dinerMenu;

    public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
    {
        this.pancakeHouseMenu = pancakeHouseMenu;
        this.dinerMenu = dinerMenu;
    }
    public void PrintMenu()
    {
        PrintMenu(pancakeHouseMenu.CreateIterator());
        PrintMenu(dinerMenu.CreateIterator());
    }

    public void PrintBreakfastMenu()
    {
        var pancakeHouseMenuIterator = pancakeHouseMenu.CreateIterator();
        while (pancakeHouseMenuIterator.HasNext())
        {
            Console.WriteLine(pancakeHouseMenuIterator.Next());
        }
    }
    public void PrintLunchMenu()
    {
        var dinerMenuIterator = dinerMenu.CreateIterator();
        while (dinerMenuIterator.HasNext())
        {
            Console.WriteLine(dinerMenuIterator.Next());
        }
    }
    public void PrintVegetarianMenu()
    {
        PrintVegetarianMenu(pancakeHouseMenu.CreateIterator());
        PrintVegetarianMenu(dinerMenu.CreateIterator());
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
