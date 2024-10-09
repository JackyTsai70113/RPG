using RPG.Services.Command.RemoteControlWithUndo.Receivers;

namespace RPG.Services.Command.RemoteControlWithUndo.Commands;

public class StereoOnWithCDCommand : ICommand
{
    private readonly Stereo _stereo;

    public StereoOnWithCDCommand(Stereo stereo)
    {
        _stereo = stereo;
    }

    public void Execute()
    {
        _stereo.On();
        _stereo.SetCd();
        _stereo.SetVolumn(11);
    }

    public void Undo()
    {
        _stereo.Off();
    }
}
