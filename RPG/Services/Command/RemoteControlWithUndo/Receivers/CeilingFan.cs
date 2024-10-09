namespace RPG.Services.Command.RemoteControlWithUndo.Receivers;

public class CeilingFan
{
    private readonly string _location;
    private CeilingFanLevel _level;
    public CeilingFan(string location)
    {
        _location = location;
        _level = CeilingFanLevel.OFF;
    }
    public void High()
    {
        _level = CeilingFanLevel.HIGH;
        Console.WriteLine($"{_location} ceiling fan is on high");
    }

    public void Medium()
    {
        _level = CeilingFanLevel.MEDIUM;
        Console.WriteLine($"{_location} ceiling fan is on medium");
    }

    public void Low()
    {
        _level = CeilingFanLevel.LOW;
        Console.WriteLine($"{_location} ceiling fan is on low");
    }

    public void Off()
    {
        _level = CeilingFanLevel.OFF;
        Console.WriteLine($"{_location} ceiling fan is off");
    }

    public CeilingFanLevel GetSpeed() => _level;

    public enum CeilingFanLevel
    {
        OFF = 0,
        LOW = 1,
        MEDIUM = 2,
        HIGH = 3
    }
}
