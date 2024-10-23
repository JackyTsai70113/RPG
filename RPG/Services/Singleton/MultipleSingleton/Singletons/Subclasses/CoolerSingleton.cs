namespace RPG.Services.Singleton.MultipleSingleton.Singletons.Subclasses;

public class CoolerSingleton : BaseSingleton
{
    protected static readonly BaseSingleton UniqueInstance;

    private CoolerSingleton() { }
}
