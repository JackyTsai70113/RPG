using RPG.Services.Command.RemoteControl.Receivers;

namespace RPG.Services.Command.RemoteControl.Commands;

public class GarageDoorDownCommand : ICommand
{
    private readonly GarageDoor _garageDoor;

    public GarageDoorDownCommand(GarageDoor garageDoor)
    {
        _garageDoor = garageDoor;
    }
    public void Execute()
    {
        _garageDoor.Down();
    }
}
