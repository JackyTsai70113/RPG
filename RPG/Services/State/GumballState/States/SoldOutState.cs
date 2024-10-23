namespace RPG.Services.State.GumballState.States;

public class SoldOutState : IState
{
    private readonly GumballMachine _gumballMachine;

    public SoldOutState(GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }
    public void InsertQuarter()
    {
        Console.WriteLine("You can't insert a quarter, the machane is sold out");
    }
    public void EjectQuarter()
    {
        Console.WriteLine("You can't eject,you haven't inserted a quarter yet");
    }
    public bool TurnCrank()
    {
        Console.WriteLine("You turned, but there are no gumballs");
        return false;
    }
    public void Dispense()
    {
        Console.WriteLine("No gumball dispensed");
    }
    public void Refill()
    {
        _gumballMachine.SetState(_gumballMachine.NoQuarterState);
    }
    public override string ToString()
    {
        return "sold out";
    }
}
