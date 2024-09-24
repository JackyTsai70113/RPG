namespace RPG.Services.Facade.HomeTheater.Subsystems;

public class Tuner
{
    private readonly string description;
    private readonly Amplifier amplifier;
    private double frequency;

    public Tuner(string description, Amplifier amplifier)
    {
        this.description = description;
        this.amplifier = amplifier;
    }

    public void On()
    {
        Console.WriteLine($"{description} on");
    }

    public void Off()
    {
        Console.WriteLine($"{description} off");
    }

    public void SetFrequency(double frequency)
    {
        Console.WriteLine($"{description} setting frequency to {frequency}");
        this.frequency = frequency;
    }

    public void SetAm()
    {
        Console.WriteLine($"{description} setting AM mode");
    }

    public void SetFm()
    {
        Console.WriteLine($"{description} setting FM mode");
    }

    public override string ToString()
    {
        return description;
    }
}
