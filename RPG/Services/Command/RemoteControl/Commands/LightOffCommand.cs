using RPG.Services.Command.RemoteControl.Receivers;

namespace RPG.Services.Command.RemoteControl.Commands;

public class LightOffCommand : ICommand
{
    private readonly Light _light;

    public LightOffCommand(Light light)
    {
        _light = light;
    }
    public void Execute()
    {
        _light.Off();
    }
}
