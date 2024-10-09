using System.Text;
using RPG.Services.Command.RemoteControl.Commands;

namespace RPG.Services.Command.RemoteControl.Invokers;

public class RemoteControl
{
    private readonly ICommand[] _onCommands;
    private readonly ICommand[] _offCommands;
    public RemoteControl()
    {
        _onCommands = new ICommand[7];
        _offCommands = new ICommand[7];
        for (int i = 0; i < _onCommands.Length; i++)
        {
            _onCommands[i] = new NoCommand();
            _offCommands[i] = new NoCommand();
        }
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        if (slot >= 7) return;
        _onCommands[slot] = onCommand;
        _offCommands[slot] = offCommand;
    }

    public void OnButtonWasPressed(int slot)
    {
        if (slot >= 7) return;
        _onCommands[slot].Execute();
    }

    public void OffButtonWasPressed(int slot)
    {
        if (slot >= 7) return;
        _offCommands[slot].Execute();
    }

    public override string ToString()
    {
        StringBuilder sb = new();
        sb.AppendLine("\n----- Remote Control -------");
        for (int i = 0; i < _onCommands.Length; i++)
        {
            sb.AppendLine($"[slot {i}] {_onCommands[i].GetType().Name} {_offCommands[i].GetType().Name}");
        }
        return sb.ToString();
    }
}
