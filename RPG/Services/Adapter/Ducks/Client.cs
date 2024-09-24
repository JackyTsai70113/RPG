using RPG.Services.Adapter.Ducks.Adapters;
using RPG.Services.Adapter.Ducks.Models.Ducks;
using RPG.Services.Adapter.Ducks.Models.Turkeys;

namespace RPG.Services.Adapter.Ducks;

public static class Client
{
    public static void ShowAnimals()
    {
        MallardDuck duck = new();
        WildTurkey turkey = new();
        IDuck turkeyAdapter = new TurkeyAdapter(turkey);

        Console.WriteLine("The Turkey says...");
        turkey.Gobble();
        turkey.Fly();

        Console.WriteLine("\nThe Duck says...");
        TestDuck(duck);

        Console.WriteLine("\nThe TurkeyAdapter says...");
        TestDuck(turkeyAdapter);
    }
    static void TestDuck(IDuck duck)
    {
        duck.Quack();
        duck.Fly();
    }
}
