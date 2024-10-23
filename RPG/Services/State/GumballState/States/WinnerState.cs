namespace RPG.Services.State.GumballState.States;

public class WinnerState : IState
{
    private readonly GumballMachine _gumballMachine;

    public WinnerState(GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }
    public void InsertQuarter()
    {
        Console.WriteLine("Please wait, we're already giving you a gumball");
    }
    public void EjectQuarter()
    {
        Console.WriteLine("Sorry, you already turned the crank");
    }
    public bool TurnCrank()
    {
        Console.WriteLine("Turning twice doesn't get you another gumball!");
        return false;
    }
    public void Dispense()
    {
        _gumballMachine.ReleaseBall();
        if (_gumballMachine.Count == 0)
        {
            _gumballMachine.SetState(_gumballMachine.SoldOutState);
        }
        else
        {
            _gumballMachine.ReleaseBall();
            Console.WriteLine("YOU'RE A WINNER! Your got two gumballs for your quarter");
            if (_gumballMachine.Count == 0)
            {
                _gumballMachine.SetState(_gumballMachine.SoldOutState);
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.NoQuarterState);
            }
        }
    }
    public void Refill() { }
    public override string ToString()
    {
        return "delivering a gumball";
    }
}
