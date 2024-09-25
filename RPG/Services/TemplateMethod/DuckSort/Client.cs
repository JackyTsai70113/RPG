namespace RPG.Services.TemplateMethod.DuckSort;

public static class Client
{
    public static void SortDucks()
    {
        Duck[] ducks = new Duck[]{
            new ("Daffy", 8),
            new ("Dewey", 2),
            new ("Howard", 7),
            new ("Louie", 2),
            new ("Donald", 10),
            new ("Huey", 2),
        };

        Console.WriteLine("Before sorting");
        Display(ducks);

        Array.Sort(ducks);

        Console.WriteLine("\nAfter sorting");
        Display(ducks);
    }

    private static void Display(Duck[] ducks)
    {
        foreach (var duck in ducks)
        {
            Console.WriteLine(duck);
        }
    }
}
