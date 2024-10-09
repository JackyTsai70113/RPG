using System.Text;
using RPG.Services.Command.RemoteControlWithUndo.Commands;

namespace RPG.Services.Command.RemoteControlWithUndo.Invokers;

public class RemoteControl
{
    private readonly ICommand[] _onCommands;
    private readonly ICommand[] _offCommands;
    private ICommand _undoCommand;
    public RemoteControl()
    {
        _onCommands = new ICommand[7];
        _offCommands = new ICommand[7];
        for (int i = 0; i < _onCommands.Length; i++)
        {
            _onCommands[i] = new NoCommand();
            _offCommands[i] = new NoCommand();
        }
        _undoCommand = new NoCommand();
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
        _undoCommand = _onCommands[slot];
    }

    public void OffButtonWasPressed(int slot)
    {
        if (slot >= 7) return;
        _offCommands[slot].Execute();
        _undoCommand = _offCommands[slot];
    }

    public void UndoButtonWasPressed()
    {
        _undoCommand.Undo();
    }

    public override string ToString()
    {
        StringBuilder sb = new();
        sb.AppendLine("\n----- Remote Control -------");
        for (int i = 0; i < _onCommands.Length; i++)
        {
            sb.AppendLine($"[slot {i}] {_onCommands[i].GetType().Name} {_offCommands[i].GetType().Name}");
        }
        sb.AppendLine($"[undo] {_undoCommand.GetType().Name}");
        return sb.ToString();
    }
}
