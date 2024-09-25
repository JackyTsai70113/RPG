namespace RPG.Services.TemplateMethod.Barista;

public abstract class CaffeineBeverage
{
    public void PrepareRecipe()
    {
        BoidWater();
        Brew();
        PourInCup();
        AddCondiments();
    }

    public abstract void Brew();
    public abstract void AddCondiments();
    public void BoidWater()
    {
        Console.WriteLine("Boiling water");
    }
    public void PourInCup()
    {
        Console.WriteLine("Pouring into cup");
    }
}
