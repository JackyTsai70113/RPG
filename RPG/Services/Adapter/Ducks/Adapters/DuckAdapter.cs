using RPG.Services.Adapter.Ducks.Models.Ducks;
using RPG.Services.Adapter.Ducks.Models.Turkeys;

namespace RPG.Services.Adapter.Ducks.Adapters;

public class DuckAdapter : ITurkey
{
    private readonly IDuck duck;
    private readonly Random random;
    public DuckAdapter(IDuck duck)
    {
        this.duck = duck;
        random = new();
    }
    public void Fly()
    {
        if (random.Next(5) == 0)
        {
            duck.Fly();
        }
    }

    public void Gobble()
    {
        duck.Quack();
    }
}
