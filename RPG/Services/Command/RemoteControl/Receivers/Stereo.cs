namespace RPG.Services.Command.RemoteControl.Receivers;

public class Stereo
{
    private readonly string _location;

    public Stereo(string location)
    {
        _location = location;
    }
    public void On() => Console.WriteLine($"{_location} stereo is on");

    public void Off() => Console.WriteLine($"{_location} stereo is off");

    public void SetCd() => Console.WriteLine($"{_location} stereo Set Cd");

    public void SetDvd() => Console.WriteLine($"{_location} stereo Set Dvd");

    public void SetRadio() => Console.WriteLine($"{_location} stereo Set Radio");

    public void SetVolumn(int volumn) { Console.WriteLine($"{_location} Set Volumn {volumn}"); }
}
