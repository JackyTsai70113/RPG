namespace RPG.Services.Command.RemoteControlWithUndo.Receivers;

public class GarageDoor
{
    private readonly string _location;

    public GarageDoor(string location)
    {
        _location = location;
    }
    public void Up() => Console.WriteLine($"{_location} Garage door is Open");

    public void Down() => Console.WriteLine($"{_location} Garage door is Closed");

    public void Stop() => Console.WriteLine($"{_location} Garage door is Stopped");

    public void LightOn() => Console.WriteLine($"{_location} Garage light is on");

    public void LightOff() => Console.WriteLine($"{_location} Garage light is off");
}
