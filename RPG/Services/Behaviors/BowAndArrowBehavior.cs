namespace RPG.Services.Behaviors;

public class BowAndArrowBehavior : IWeaponBehavior
{
    public void UseWeapon()
    {
        Console.WriteLine("use bow and arrow!");
    }
}
