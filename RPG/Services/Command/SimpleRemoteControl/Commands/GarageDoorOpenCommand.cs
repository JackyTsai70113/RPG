using RPG.Services.Command.SimpleRemoteControl.Receivers;

namespace RPG.Services.Command.SimpleRemoteControl.Commands;

public class GarageDoorOpenCommand : ICommand
{
    private readonly GarageDoor garageDoor;

    public GarageDoorOpenCommand(GarageDoor garageDoor)
    {
        this.garageDoor = garageDoor;
    }
    public void Execute()
    {
        garageDoor.Up();
    }
}
