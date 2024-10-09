using RPG.Services.Command.SimpleRemoteControl.Commands;
using RPG.Services.Command.SimpleRemoteControl.Receivers;

namespace RPG.Services.Command.SimpleRemoteControl;

public static class Client
{
    public static void RemoteControlTest()
    {
        var remote = new Invokers.SimpleRemoteControl();
        Light light = new();
        GarageDoor garageDoor = new();
        LightOnCommand lightOnCommand = new(light);
        GarageDoorOpenCommand garageDoorOpenCommand = new(garageDoor);
        remote.SetCommand(lightOnCommand);
        remote.ButtonWasPressed();
        remote.SetCommand(garageDoorOpenCommand);
        remote.ButtonWasPressed();
    }
}
