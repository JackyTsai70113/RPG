using System.Collections;

namespace RPG.Services.Iterator.DinerMergerCafe;

public class DinerMenuIterator : IEnumerator<MenuItem>
{
    private readonly IEnumerator _enumerator;

    public DinerMenuIterator(MenuItem[] menuItems)
    {
        _enumerator = menuItems.GetEnumerator();
    }

    public MenuItem Current => (MenuItem)_enumerator.Current;

    object IEnumerator.Current => throw new NotImplementedException();

    public void Dispose()
    {
    }

    public bool MoveNext()
    {
        return _enumerator.MoveNext();
    }

    public void Reset()
    {
        _enumerator.Reset();
    }
}
