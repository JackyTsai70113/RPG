namespace RPG.Services.Iterator.DinerMerger;

public static class Client
{
    public static void Test()
    {
        PancakeHouseMenu pancakeHouseMenu = new();
        DinerMenu dinerMenu = new();
        Waitress waitress = new(pancakeHouseMenu, dinerMenu);
        waitress.PrintMenu();
    }
}
