namespace RPG.Services.Iterator.DinerMerger;

public class DinerMenu : IMenu
{
    private const int MAX_ITEMS = 6;
    private int _numberOfItems;
    private readonly MenuItem[] menuItems;

    public DinerMenu()
    {
        menuItems = new MenuItem[MAX_ITEMS];

        AddItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99m);
        AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99m);
        AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29m);
        AddItem("Hotdog", "A hot dog, with sauerkraut, relish, onions, topped with cheese", false, 3.05m);
        AddItem("Steamed Veggies and Brown Rice", "Steamed vegetables over brown rice", true, 3.99m);
        AddItem("Pasta", "Spaghetti with Marinara Sauce, and a slice of sourdough bread", true, 3.89m);
    }

    public void AddItem(string name, string description, bool vegetarian, decimal price)
    {
        if (_numberOfItems >= MAX_ITEMS)
        {
            Console.WriteLine("Sorry, menu is full!  Can't add item to menu");
        }
        menuItems[_numberOfItems++] = new MenuItem(name, description, vegetarian, price);
    }

    // 不需要，這方法公開了內部實作
    public MenuItem[] GetMenuItems()
    {
        return menuItems;
    }

    public IIterator<MenuItem> CreateIterator()
    {
        return new DinerMenuIterator(menuItems);
    }
}
