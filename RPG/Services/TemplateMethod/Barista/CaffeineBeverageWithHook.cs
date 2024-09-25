
namespace RPG.Services.TemplateMethod.Barista;

public abstract class CaffeineBeverageWithHook
{
    public void PrepareRecipe()
    {
        BoidWater();
        Brew();
        PourInCup();
        if (CustomerWantsCondiments())
        {
            AddCondiments();
        }
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
    public virtual bool CustomerWantsCondiments()
    {
        return true;
    }
}
