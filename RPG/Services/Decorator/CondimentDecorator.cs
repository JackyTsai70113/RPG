namespace RPG.Services.Decorator;

public abstract class CondimentDecorator : Beverage
{
    internal Beverage beverage;
    public abstract string GetDescription();

    public Size GetSize()
    {
        return beverage.GetSize();
    }
}
