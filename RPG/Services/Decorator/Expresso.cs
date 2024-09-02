namespace RPG.Services.Decorator;

public class Expresso : Beverage
{
    public Expresso()
    {
        Description = "Expresso";
    }
    public override double Cost()
    {
        return 1.99;
    }
}
