namespace RPG.Services.Decorator
{
    public class Soy : CondimentDecorator
    {
        private readonly Beverage beverage;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string Description => beverage.Description + ", Soy";
        public override void SetSize(SizeType size)
        {
            beverage.SetSize(size);
        }
        public override SizeType GetSize()
        {
            return beverage.GetSize();
        }
        public override double Cost()
        {
            var cost = beverage.Cost();
            switch (beverage.GetSize())
            {
                case SizeType.TALL:
                    cost += 0.1;
                    break;
                case SizeType.GRANDE:
                    cost += 0.15;
                    break;
                case SizeType.VENTI:
                    cost += 0.2;
                    break;
            }
            return cost;
        }
    }
}
