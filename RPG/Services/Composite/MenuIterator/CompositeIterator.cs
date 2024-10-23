using System.Collections;

namespace RPG.Services.Composite.MenuIterator;

public class CompositeIterator : IEnumerator<MenuComponent>
{
    public CompositeIterator(IEnumerator<MenuComponent> iterator)
    {
        
    }
    public MenuComponent Current => throw new NotImplementedException();

    object IEnumerator.Current => throw new NotImplementedException();

    public void Dispose()
    {
    }

    public bool MoveNext()
    {
        throw new NotImplementedException();
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
}
