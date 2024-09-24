namespace RPG.Services.Adapter.Ducks.Models.Ducks;

public class MallardDuck : IDuck
{
    public void Fly()
    {
        Console.WriteLine("I'm flying");
    }

    public void Quack()
    {
        Console.WriteLine("Quack");
    }
}
