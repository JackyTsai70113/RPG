namespace RPG.Services.State.GumballState;

public static class Client
{
    public static void Test()
    {
        GumballMachine gumballMachine = new(2);

        Console.WriteLine(gumballMachine);

        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();

        Console.WriteLine(gumballMachine);

        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();
        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();

        gumballMachine.Refill(5);
        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();

        Console.WriteLine(gumballMachine);
    }
}
