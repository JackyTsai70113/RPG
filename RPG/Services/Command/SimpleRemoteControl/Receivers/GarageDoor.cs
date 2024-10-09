namespace RPG.Services.Command.SimpleRemoteControl.Receivers;

public class GarageDoor
{
    public GarageDoor() { }
    public void Up() => Console.WriteLine("Garage door is Open");

    public void Down() => Console.WriteLine("Garage door is Close");

    public void Stop() => Console.WriteLine("Garage door stop");

    public void LightOn() => Console.WriteLine("Garage door light on");

    public void LightOff() => Console.WriteLine("Garage door light off");
}
