namespace RPG.Services.Decorator;

public abstract class CondimentDecorator : Beverage
{
    protected Beverage beverage;
    public abstract string GetDescription();
}
