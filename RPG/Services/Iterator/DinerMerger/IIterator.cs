namespace RPG.Services.Iterator.DinerMerger;

public interface IIterator<T>
{
    bool HasNext();
    T Next();
}
