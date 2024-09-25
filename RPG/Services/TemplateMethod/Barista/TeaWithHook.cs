namespace RPG.Services.TemplateMethod.Barista;

public class TeaWithHook : CaffeineBeverageWithHook
{
    public override void AddCondiments()
    {
        Console.WriteLine("Adding Lemon");
    }

    public override void Brew()
    {
        Console.WriteLine("Steeping the tea");
    }

    public override bool CustomerWantsCondiments()
    {
        string answer = GetUserInput();
        return answer.ToLower().StartsWith("y");
    }

    private static string GetUserInput()
    {
        string? answer = null;
        Console.WriteLine("Would you like lemon with your tea (y/n)? ");

        answer = Console.ReadLine();

        return answer ?? "no";
    }
}
