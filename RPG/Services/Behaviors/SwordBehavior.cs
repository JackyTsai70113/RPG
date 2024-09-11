namespace RPG.Services.Behaviors
{
    public class SwordBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("use sword!");
        }
    }
}
