using RPG.Services.Behaviors;

namespace RPG.Services.Characters;

public abstract class Character
{
    private IWeaponBehavior weapon;

    public Character()
    {
        weapon = new NoWeaponBehavior();
    }

    public void SetWeapon(IWeaponBehavior w)
    {
        weapon = w;
    }

    public void Fight()
    {
        weapon.UseWeapon();
    }
}
