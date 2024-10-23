namespace RPG.Services.State.GumballState.States;

public interface IState
{
    /// <summary>
    /// 投入25美元
    /// </summary>
    public void InsertQuarter();
    /// <summary>
    /// 退回25美元
    /// </summary>
    public void EjectQuarter();
    /// <summary>
    /// 轉動旋鈕
    /// </summary>
    public bool TurnCrank();
    /// <summary>
    /// 投放糖果，供機器呼叫
    /// </summary>
    public void Dispense();
    public void Refill();
}
