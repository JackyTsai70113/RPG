namespace RPG.Services.Iterator.DinerMergerCafe;

public class PancakeHouseMenu : IMenu
{
    private readonly string name = "BREAKFAST";
    readonly List<MenuItem> menuItems;

    public PancakeHouseMenu()
    {
        menuItems = new();

        AddItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99m);
        AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99m);
        AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49m);
        AddItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59m);
    }

    public void AddItem(string name, string description, bool vegetarian, decimal price)
    {
        menuItems.Add(new MenuItem(name, description, vegetarian, price));
    }

    public List<MenuItem> GetMenuItems()
    {
        return menuItems;
    }

    public IEnumerator<MenuItem> CreateIterator()
    {
        IEnumerable<int> ss = new List<int>();
        var dd = ss.GetEnumerator();
        return menuItems.GetEnumerator();
    }`

    public string GetName() => name;
}
