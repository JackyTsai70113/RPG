namespace RPG.Services.Decorator;

public abstract class Beverage
{

    protected string description;
    public Beverage()
    {
        description = "Unknown Coffee";
    }
    public string GetDescription()
    {
        return description;
    }
    public abstract double Cost();
}
