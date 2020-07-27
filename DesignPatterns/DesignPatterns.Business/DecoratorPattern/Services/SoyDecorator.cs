namespace DesignPatterns.Business.DecoratorPattern.Services
{
    public class SoyDecorator : CondimentDecorator
    {
        public override string GetDescription(string beverage)
        {
            return $"{beverage} condiment";
        }

        public virtual double GetCost(double percentage)
        {
            return 0;
        }
    }
}
