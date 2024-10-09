using RPG.Services.Command.RemoteControl.Receivers;

namespace RPG.Services.Command.RemoteControl.Commands;

public class CeilingFanOnCommand : ICommand
{
    private readonly CeilingFan _ceilingFan;

    public CeilingFanOnCommand(CeilingFan ceilingFan)
    {
        _ceilingFan = ceilingFan;
    }

    public void Execute()
    {
        _ceilingFan.High();
    }
}
