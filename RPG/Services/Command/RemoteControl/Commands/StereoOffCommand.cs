using RPG.Services.Command.RemoteControl.Receivers;

namespace RPG.Services.Command.RemoteControl.Commands;

public class StereoOffCommand : ICommand
{
    private readonly Stereo _stereo;

    public StereoOffCommand(Stereo stereo)
    {
        _stereo = stereo;
    }

    public void Execute()
    {
        _stereo.Off();
    }
}
