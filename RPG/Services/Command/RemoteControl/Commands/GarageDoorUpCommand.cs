using RPG.Services.Command.RemoteControl.Receivers;

namespace RPG.Services.Command.RemoteControl.Commands;

public class GarageDoorUpCommand : ICommand
{
    private readonly GarageDoor _garageDoor;

    public GarageDoorUpCommand(GarageDoor garageDoor)
    {
        _garageDoor = garageDoor;
    }
    public void Execute()
    {
        _garageDoor.Up();
    }
    public void Undo()
    {
        _garageDoor.Down();
    }
}
