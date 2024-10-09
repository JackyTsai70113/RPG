using RPG.Services.Command.RemoteControl.Receivers;

namespace RPG.Services.Command.RemoteControl.Commands;

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
}
