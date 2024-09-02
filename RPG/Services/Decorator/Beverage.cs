namespace RPG.Services.Decorator;

public abstract class Beverage
{
    public string description = "Unknown Beverage";
    private Size size = Size.TALL;
    public void SetSize(Size size)
    {
        this.size = size;
    }
    public Size GetSize()
    {
        return size;
    }
    public string GetDescription()
    {
        return description;
    }
    public abstract double Cost();

    public enum Size
    {
        TALL,
        GRANDE,
        VENTI
    }
}
