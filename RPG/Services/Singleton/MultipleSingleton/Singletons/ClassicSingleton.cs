namespace RPG.Services.Singleton.MultipleSingleton.Singletons;

public class ClassicSingleton
{
    private static ClassicSingleton _uniqueInstance;
    private ClassicSingleton() { }

    public static ClassicSingleton GetInstance()
    {
        _uniqueInstance ??= new();
        return _uniqueInstance;
    }
}
