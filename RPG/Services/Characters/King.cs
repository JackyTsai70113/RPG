using RPG.Services.Behaviors;

namespace RPG.Services.Characters;

public class King : Character
{
    public void RandomWeapon()
    {
        var random = new Random();
        var next = random.Next(4);
        switch (next)
        {
            case 0:
                SetWeapon(new AxeBehavior());
                break;
            case 1:
                SetWeapon(new BowAndArrowBehavior());
                break;
            case 2:
                SetWeapon(new KnifeBehavior());
                break;
            case 3:
                SetWeapon(new SwordBehavior());
                break;
        }
    }
}