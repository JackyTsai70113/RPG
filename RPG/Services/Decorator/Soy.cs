namespace RPG.Services.Decorator;

public class Soy : CondimentDecorator
{
    public Soy(Beverage beverage)
    {
        this.beverage = beverage;
    }
    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Soy";
    }
    public override double Cost()
    {
        var cost = beverage.Cost();
        switch (GetSize())
        {
            case Size.TALL:
                cost += 0.1;
                break;
            case Size.GRANDE:
                cost += 0.15;
                break;
            case Size.VENTI:
                cost += 0.2;
                break;
        }
        return cost;
    }
}
