namespace RPG.Services.Facade.HomeTheater.Subsystems;

public class PopcornPopper
{
    private readonly string description;

    public PopcornPopper(string description)
    {
        this.description = description;
    }

    public void On()
    {
        Console.WriteLine($"{description} on");
    }

    public void Off()
    {
        Console.WriteLine($"{description} off");
    }

    public void Pop()
    {
        Console.WriteLine($"{description} popping popcorn!");
    }

    public override string ToString()
    {
        return description;
    }
}
