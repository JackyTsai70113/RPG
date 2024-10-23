namespace RPG.Services.Singleton.MultipleSingleton.Singletons;

public class ThreadSafeSingleton
{
    private static volatile ThreadSafeSingleton _uniqueInstance;
    private static object _syncLock = new();
    private ThreadSafeSingleton() { }

    public static ThreadSafeSingleton GetInstance()
    {
        if (_uniqueInstance == null)
        {
            lock (_syncLock)
            {
                _uniqueInstance = new();
            }
        }
        return _uniqueInstance;
    }
}
