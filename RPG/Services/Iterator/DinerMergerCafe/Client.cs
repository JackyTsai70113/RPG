namespace RPG.Services.Iterator.DinerMergerCafe;

public static class Client
{
    public static void Test()
    {
        IMenu pancakeHouseMenu = new PancakeHouseMenu();
        IMenu dinerMenu = new DinerMenu();
        IMenu cafeMenu = new CafeMenu();
        Waitress waitress = new(pancakeHouseMenu, dinerMenu, cafeMenu);
        waitress.PrintMenu();
    }
}
