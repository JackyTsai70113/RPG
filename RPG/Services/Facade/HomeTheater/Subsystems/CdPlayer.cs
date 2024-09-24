namespace RPG.Services.Facade.HomeTheater.Subsystems;

public class CdPlayer
{
    private readonly string description;
    private readonly Amplifier amplifier;
    private string? title;
    private int? currentTrack;

    public CdPlayer(string description, Amplifier amplifier)
    {
        this.amplifier = amplifier;
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
    public void Eject()
    {
        title = null;
        Console.WriteLine($"{description} eject");
    }
    public void Play(string title)
    {
        this.title = title;
        currentTrack = 0;
        Console.WriteLine($"{description} playing \"{this.title}\"");
    }
    public void Play(int track)
    {
        if (title == null)
        {
            Console.WriteLine($"{description} can't play track {currentTrack}, no cd inserted");
        }
        else
        {
            currentTrack = track;
            Console.WriteLine($"{description} playing track {currentTrack}");
        }
    }
    public void Stop()
    {
        currentTrack = 0;
        Console.WriteLine($"{description} stopped");
    }
    public void Pause()
    {
        Console.WriteLine($"{description} paused \"{title}\"");
    }
    public override string ToString()
    {
        return description;
    }
}
