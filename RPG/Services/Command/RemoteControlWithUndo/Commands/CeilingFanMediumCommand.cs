using RPG.Services.Command.RemoteControlWithUndo.Receivers;
using static RPG.Services.Command.RemoteControlWithUndo.Receivers.CeilingFan;

namespace RPG.Services.Command.RemoteControlWithUndo.Commands;

public class CeilingFanMediumCommand : ICommand
{
    private readonly CeilingFan _ceilingFan;
    private CeilingFanLevel _prevSpeed;

    public CeilingFanMediumCommand(CeilingFan ceilingFan)
    {
        _ceilingFan = ceilingFan;
    }

    public void Execute()
    {
        _prevSpeed = _ceilingFan.GetSpeed();
        _ceilingFan.Medium();
    }

    public void Undo()
    {
        switch (_prevSpeed)
        {
            case CeilingFanLevel.HIGH:
                _ceilingFan.High();
                break;
            case CeilingFanLevel.MEDIUM:
                _ceilingFan.Medium();
                break;
            case CeilingFanLevel.LOW:
                _ceilingFan.Low();
                break;
            case CeilingFanLevel.OFF:
                _ceilingFan.Off();
                break;
        }
    }
}
