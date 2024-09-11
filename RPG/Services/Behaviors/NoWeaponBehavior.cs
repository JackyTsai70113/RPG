namespace RPG.Services.Behaviors
{
    public class NoWeaponBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("no weapon!");
        }
    }
}
