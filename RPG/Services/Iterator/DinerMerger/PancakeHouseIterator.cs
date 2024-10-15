namespace RPG.Services.Iterator.DinerMerger;

public class PancakeHouseIterator : IIterator<MenuItem>
{
    private readonly List<MenuItem> menuItems;
    private int _numberOfItems;


    public PancakeHouseIterator(List<MenuItem> menuItems)
    {
        this.menuItems = menuItems;
    }
    public bool HasNext() => _numberOfItems < menuItems.Count;

    public MenuItem Next() => menuItems[_numberOfItems++];
}
