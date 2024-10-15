namespace RPG.Services.Iterator.DinerMerger;

public class DinerMenuIterator : IIterator<MenuItem>
{
    int _numberOfItems;
    private readonly MenuItem[] menuItems;

    public DinerMenuIterator(MenuItem[] menuItems)
    {
        this.menuItems = menuItems;
    }
    public bool HasNext() => _numberOfItems < menuItems.Length && menuItems[_numberOfItems] != null;

    public MenuItem Next() => menuItems[_numberOfItems++];
}
