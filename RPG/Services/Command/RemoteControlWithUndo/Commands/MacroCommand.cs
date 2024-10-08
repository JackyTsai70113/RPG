namespace RPG.Services.Command.RemoteControlWithUndo.Commands;

public class MacroCommand : ICommand
{
    private readonly ICommand[] _commands;

    public MacroCommand(ICommand[] commands)
    {
        _commands = commands;
    }
    public void Execute()
    {
        foreach (var command in _commands)
        {
            command.Execute();
        }
    }

    public void Undo()
    {
        foreach (var command in _commands.Reverse())
        {
            command.Undo();
        }
    }
}
