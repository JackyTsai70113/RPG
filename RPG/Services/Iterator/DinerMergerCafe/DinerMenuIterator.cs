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

    object IEnumerator.Current => _enumerator.Current;

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

public class DinerMenuIterator2 : IEnumerable<MenuItem>
{
    private readonly IEnumerator _enumerator;

    public DinerMenuIterator2(MenuItem[] menuItems)
    {
        _enumerator = menuItems.GetEnumerator();
    }

    public IEnumerator<MenuItem> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}