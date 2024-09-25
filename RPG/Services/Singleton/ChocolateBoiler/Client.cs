namespace RPG.Services.Singleton.ChocolateBoiler;

public static class Client
{
    public static void ShowChocolateBoiler()
    {
        ChocolateBoiler boiler = ChocolateBoiler.GetInstance();
        Console.WriteLine("The First boiler...");
        boiler.Fill();
        boiler.Boil();
        boiler.Drain();

        ChocolateBoiler boiler2 = ChocolateBoiler.GetInstance();
        Console.WriteLine("The Second boiler...");
        boiler.Drain();
    }
}
