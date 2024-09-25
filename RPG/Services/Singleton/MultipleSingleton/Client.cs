using RPG.Services.Singleton.MultipleSingleton.Singletons.Subclasses;

namespace RPG.Services.Singleton.MultipleSingleton;

public static class Client
{
    public static void ShowCoolerAndHotterSingleton()
    {
        var foo = CoolerSingleton.GetInstance();
        var bar = HotterSingleton.GetInstance();

        Console.WriteLine(foo == bar);
        Console.WriteLine(foo);
        Console.WriteLine(bar);
    }
}
