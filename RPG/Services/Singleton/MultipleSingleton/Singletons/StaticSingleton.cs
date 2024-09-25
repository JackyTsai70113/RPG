namespace RPG.Services.Singleton.MultipleSingleton.Singletons;

public class StaticSingleton
{
    private static readonly StaticSingleton _uniqueInstance = new();
    private StaticSingleton() { }

    public static StaticSingleton GetInstance()
    {
        return _uniqueInstance;
    }
}
