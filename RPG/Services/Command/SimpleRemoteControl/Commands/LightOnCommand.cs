using RPG.Services.Command.SimpleRemoteControl.Receivers;

namespace RPG.Services.Command.SimpleRemoteControl.Commands;

public class LightOnCommand : ICommand
{
    private readonly Light light;

    public LightOnCommand(Light light)
    {
        this.light = light;
    }
    public void Execute()
    {
        light.On();
    }
}
