namespace RPG.Services.Decorator;

public class Mocha : CondimentDecorator
{
    public `Mocha(Beverage beverage)
    {
        this.beverage = beverage;
    }
    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Mocha";
    }
    public override double Cost()
    {
        return beverage.Cost() + 0.2;
    }
}
