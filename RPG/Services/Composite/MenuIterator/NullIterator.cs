using System.Collections;

namespace RPG.Services.Composite.MenuIterator;

public class NullIterator : IEnumerator<MenuComponent>
{
    public MenuComponent Current => null;

    object IEnumerator.Current => Current;

    public void Dispose() { }

    public bool MoveNext() => false;

    public void Reset() { }
}
