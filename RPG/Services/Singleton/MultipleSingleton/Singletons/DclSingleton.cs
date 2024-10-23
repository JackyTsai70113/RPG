namespace RPG.Services.Singleton.MultipleSingleton.Singletons;

public class DclSingleton
{
    private static volatile DclSingleton _uniqueInstance;
    private static object _syncLock = new();
    private DclSingleton() { }

    public static DclSingleton GetInstance()
    {
        if (_uniqueInstance == null)
        {
            lock (_syncLock)
            {
                _uniqueInstance ??= new();
            }
        }
        return _uniqueInstance;
    }
}
