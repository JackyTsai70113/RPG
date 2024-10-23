namespace RPG.Services.Facade.HomeTheater.Subsystems;

public class Amplifier
{
    private readonly string description;
    public Amplifier(string description)
    {
        this.description = description;
    }
    public Tuner Tuner { get; private set; }
    public DvdPlayer Dvd { get; private set; }
    public CdPlayer Cd { get; private set; }

    public void On()
    {
        Console.WriteLine($"{description} on");
    }
    public void Off()
    {
        Console.WriteLine($"{description} off");
    }
    public void SetStereoSound()
    {
        Console.WriteLine($"{description} stereo mode on");
    }
    public void SetSurroundSound()
    {
        Console.WriteLine($"{description} surround sound on (5 speakers, 1 subwoofer)");
    }
    public void SetVolume(int level)
    {
        Console.WriteLine($"{description} setting volume to {level}");
    }
    public void SetTuner(Tuner tuner)
    {
        Console.WriteLine($"{description} setting tuner to {tuner}");
        Tuner = tuner;
    }
    public void SetDvd(DvdPlayer dvd)
    {
        Console.WriteLine($"{description} setting DVD player to {dvd}");
        Dvd = dvd;
    }
    public void SetCd(CdPlayer cd)
    {
        Console.WriteLine($"{description} setting Cd player to {cd}");
        Cd = cd;
    }
    public override string ToString()
    {
        return description;
    }
}
