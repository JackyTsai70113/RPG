namespace RPG.Services.Decorator;

public abstract class Beverage
{
    public virtual string Description { get; protected set; } = "Unknown Beverage";

    protected SizeType Size { get; set; } = SizeType.TALL;
    public virtual void SetSize(SizeType size)
    {
        Size = size;
    }
    public virtual SizeType GetSize()
    {
        return Size;
    }
    public abstract double Cost();

    public enum SizeType
    {
        TALL,
        GRANDE,
        VENTI
    }
}
