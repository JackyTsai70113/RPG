namespace RPG.Services.Singleton.ChocolateBoiler;

public class ChocolateBoiler
{
    private bool _empty;
    private bool _boiled;

    private static ChocolateBoiler? _uniqueInstance;
    private ChocolateBoiler()
    {
        _empty = true;
        _boiled = false;
    }

    public static ChocolateBoiler GetInstance()
    {
        _uniqueInstance ??= new();
        return _uniqueInstance;
    }

    /// <summary>
    /// 將牛奶/巧克力混合物送入鍋爐
    /// </summary>
    public void Fill()
    {
        Console.WriteLine("Fill boiler...");
        if (_empty)
        {
            _empty = false;
            _boiled = false;
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }

    /// <summary>
    /// 確認條件，並排出煮沸的巧克力和牛奶
    /// </summary>
    public void Drain()
    {
        Console.WriteLine("Drain chocolate...");
        if (!_empty && _boiled)
        {
            _empty = true;
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }

    /// <summary>
    /// 確認條件，並將爐內的原料煮沸
    /// </summary>
    public void Boil()
    {
        Console.WriteLine("Boil chocolate...");
        if (!_empty && !_boiled)
        {
            _boiled = true;
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}
