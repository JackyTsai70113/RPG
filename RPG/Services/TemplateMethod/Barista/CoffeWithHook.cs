namespace RPG.Services.TemplateMethod.Barista;

public class CoffeeWithHook : CaffeineBeverageWithHook
{
    public override void AddCondiments()
    {
        Console.WriteLine("Adding Sugar and Milk");
    }

    public override void Brew()
    {
        Console.WriteLine("Dripping Coffee through filter");
    }

    public override bool CustomerWantsCondiments()
    {
        string answer = GetUserInput();
        return answer.ToLower().StartsWith("y");
    }

    private static string GetUserInput()
    {
        string answer = null;
        Console.WriteLine("Would you like milk and sugar with your coffee (y/n)? ");

        answer = Console.ReadLine();

        return answer ?? "no";
    }
}
