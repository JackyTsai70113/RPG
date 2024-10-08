using RPG.Services.Command.RemoteControlWithUndo.Receivers;

namespace RPG.Services.Command.RemoteControlWithUndo.Commands;

public class HottubOffCommand : ICommand
{
    private readonly Hottub _hottub;

    public HottubOffCommand(Hottub hottub)
    {
        _hottub = hottub;
    }
    public void Execute()
    {
        _hottub.SetTemperature(98);
        _hottub.Off();
    }

    public void Undo() => _hottub.On();
}
