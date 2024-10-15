namespace RPG.Services.Iterator.DinerMergerCafe;

public interface IMenu
{
    public IEnumerator<MenuItem> CreateIterator();
    public string GetName();
}
