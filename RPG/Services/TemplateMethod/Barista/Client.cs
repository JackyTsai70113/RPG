namespace RPG.Services.TemplateMethod.Barista;

public static class Client
{
    public static void OrderBeverage()
    {
        Coffee coffee = new();
        Tea tea = new();

        Console.WriteLine("Making coffee...");
        coffee.PrepareRecipe();

        Console.WriteLine("\nMaking tea...");
        tea.PrepareRecipe();

        CoffeeWithHook coffeeWithHook = new();
        TeaWithHook teaWithHook = new();

        Console.WriteLine("\nMaking coffee...");
        coffeeWithHook.PrepareRecipe();

        Console.WriteLine("\nMaking tea...");
        teaWithHook.PrepareRecipe();
    }
}
