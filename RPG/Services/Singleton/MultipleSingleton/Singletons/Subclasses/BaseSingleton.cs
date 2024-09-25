namespace RPG.Services.Singleton.MultipleSingleton.Singletons.Subclasses;

public class BaseSingleton
{
    private static BaseSingleton? _uniqueInstance;
    private static readonly object _syncLock = new();

    public static BaseSingleton GetInstance()
    {
        lock (_syncLock)
        {
            // Lazy initialization
            _uniqueInstance ??= new();
        }
        return _uniqueInstance;
    }

    protected BaseSingleton() { }
}
