namespace RPG.Services.Decorator
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string Description => beverage.Description + ", Mocha";
        public override double Cost()
        {
            return beverage.Cost() + 0.2;
        }
    }
}
