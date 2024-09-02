namespace RPG.Services.Decorator;

public class Decaf : Beverage
{
    public Decaf()
    {
        Description = "Decaf Coffee";
    }
    public override double Cost()
    {
        return 1.05;
    }
}
