using RPG.Services.Command.RemoteControlWithUndo.Receivers;

namespace RPG.Services.Command.RemoteControlWithUndo.Commands;

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
