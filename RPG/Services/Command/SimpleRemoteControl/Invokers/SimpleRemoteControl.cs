using RPG.Services.Command.SimpleRemoteControl.Commands;

namespace RPG.Services.Command.SimpleRemoteControl.Invokers;

public class SimpleRemoteControl
{
    private ICommand slot = new NoCommand();

    public void SetCommand(ICommand command)
    {
        slot = command;
    }

    public void ButtonWasPressed()
    {
        slot.Execute();
    }
}
