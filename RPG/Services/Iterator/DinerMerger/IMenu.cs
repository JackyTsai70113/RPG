namespace RPG.Services.Iterator.DinerMerger;

public interface IMenu
{
    IIterator<MenuItem> CreateIterator();
}
