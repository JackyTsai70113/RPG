namespace RPG.Services.Command.RemoteControlWithUndo.Commands;

public interface ICommand
{
    void Execute();

    void Undo();
}
