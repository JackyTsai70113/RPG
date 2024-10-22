using System.Text;

namespace RPG.Services.State.Gumball;

public class GumballMachine
{
    private int _count;
    private State _state = State.SOLD_OUT;
    public GumballMachine(int count)
    {
        _count = count;
        if (count > 0)
        {
            _state = State.NO_QUARTER;
        }
    }
    /// <summary>
    /// 投入25美元
    /// </summary>
    public void InsertQuarter()
    {
        switch (_state)
        {
            case State.SOLD_OUT:
                Console.WriteLine("You can't insert a quarter, the machane is sold out");
                break;
            case State.NO_QUARTER:
                Console.WriteLine("You inserted a quarter");
                _state = State.HAS_QUARTER;
                break;
            case State.HAS_QUARTER:
                Console.WriteLine("You can't insert another quarter");
                break;
            case State.SOLD:
                Console.WriteLine("Please wait, we're already giving you a gumball");
                break;
        }
    }
    /// <summary>
    /// 退回25美元
    /// </summary>
    public void EjectQuarter()
    {
        switch (_state)
        {
            case State.SOLD_OUT:
                Console.WriteLine("You can't eject,you haven't inserted a quarter yet");
                break;
            case State.NO_QUARTER:
                Console.WriteLine("you haven't inserted a quarter");
                break;
            case State.HAS_QUARTER:
                Console.WriteLine("Quarter returned");
                _state = State.NO_QUARTER;
                break;
            case State.SOLD:
                Console.WriteLine("Sorry, you already turned the crank");
                break;
        }
    }
    /// <summary>
    /// 轉動旋鈕
    /// </summary>
    public void TurnCrank()
    {
        switch (_state)
        {
            case State.SOLD_OUT:
                Console.WriteLine("You turned, but there are no gumballs");
                break;
            case State.NO_QUARTER:
                Console.WriteLine("You turned but there's no quarter");
                break;
            case State.HAS_QUARTER:
                Console.WriteLine("You turned...");
                _state = State.SOLD;
                Dispense();
                break;
            case State.SOLD:
                Console.WriteLine("Turning twice doesn't get you another gumball!");
                break;
        }
    }
    /// <summary>
    /// 投放糖果，供機器呼叫
    /// </summary>
    public void Dispense()
    {
        switch (_state)
        {
            case State.SOLD_OUT:
                Console.WriteLine("No gumball dispensed");
                break;
            case State.NO_QUARTER:
                Console.WriteLine("You need to pay first");
                break;
            case State.HAS_QUARTER:
                Console.WriteLine("No gumball dispensed");
                break;
            case State.SOLD:
                Console.WriteLine("A gumball comes rolling out the slot");
                _count--;
                if (_count > 0)
                {
                    _state = State.NO_QUARTER;
                }
                else
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    _state = State.SOLD_OUT;
                }
                break;
        }
    }

    public void Refill(int numGumBalls)
    {
        _count = numGumBalls;
        _state = State.NO_QUARTER;
    }

    public override string ToString()
    {
        StringBuilder result = new();
        result.Append("\nMighty Gumball, Inc.");
        result.Append("\nC#-enabled Standing Gumball Model #2024\n");
        result.Append("Inventory: " + _count + " gumball");
        if (_count != 1)
        {
            result.Append('s');
        }
        result.Append("\nMachine is ");
        if (_state == State.SOLD_OUT)
        {
            result.Append("sold out");
        }
        else if (_state == State.NO_QUARTER)
        {
            result.Append("waiting for quarter");
        }
        else if (_state == State.HAS_QUARTER)
        {
            result.Append("waiting for turn of crank");
        }
        else if (_state == State.SOLD)
        {
            result.Append("delivering a gumball");
        }
        result.Append("\n");
        return result.ToString();
    }

    public enum State
    {
        SOLD_OUT = 0,
        NO_QUARTER = 1,
        HAS_QUARTER = 2,
        SOLD = 3
    }
}
