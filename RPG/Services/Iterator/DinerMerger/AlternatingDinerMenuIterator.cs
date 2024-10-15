using System.Collections;

namespace RPG.Services.Iterator.DinerMerger;

public class AlternatingDinerMenuIterator : IIterator<MenuItem>
{
    private readonly MenuItem[] menuItems;
    private int position;

    public AlternatingDinerMenuIterator(MenuItem[] menuItems)
    {
        this.menuItems = menuItems;
        position = (int)DateTime.Today.DayOfWeek % 2;
    }

    public void Remove()
    {
        throw new NotImplementedException("Alternating Diner Menu Iterator does not support Remove()");
    }

    public bool HasNext() => position < menuItems.Length && menuItems[position] != null;

    public MenuItem Next()
    {
        var menuItem = menuItems[position];
        position += 2;
        return menuItem;
    }
}
